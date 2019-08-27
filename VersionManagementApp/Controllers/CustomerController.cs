using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VersionManagementApp.Models;

namespace VersionManagementApp.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            var vm = RequestMakerWrapper.Instance.Customers.Get();
            return View(vm);
        }
        [Route("[controller]/{id}")]
        public IActionResult Index(Guid id)
        {
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            var vm = RequestMakerWrapper.Instance.CustomerProductsByCustomerId.GetManyById(id);
            return View("Details", vm);
        }
    }
}