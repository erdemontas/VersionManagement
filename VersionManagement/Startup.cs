using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using VersionManagement.Models;
using AutoMapper;
using VersionManagement.Profiles;
using VersionManagement.Interfaces;
using VersionManagement.Wrappers;
using FluentValidation.AspNetCore;
using VersionManagement.Extensions;
namespace VersionManagement
{

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var config = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MyProfiles());
            });
            var mapper = config.CreateMapper();
            services.AddSingleton(mapper);
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
            services.AddDbContext<VManagementContext>(options => options.UseSqlServer(Configuration.GetConnectionString("devConnection")).UseLazyLoadingProxies());
            services.AddMvc().AddFluentValidation(fv => 
            {
                fv.ImplicitlyValidateChildProperties = true;
            });
            services.AddDTOValidators();
            services.AddEntityValidators();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
