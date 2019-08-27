using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VersionManagement.DTOs;
using VersionManagementApp.Models;

namespace VersionManagementApp.Controllers
{
    public class CustomerProductController : Controller
    {
        public IActionResult Index()
        {
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            var vm = RequestMakerWrapper.Instance.CustomerProducts.Get();
            return View(vm);
        }

        [Route("[controller]/{id}")]
        public IActionResult Index(Guid id)
        {
            IEnumerable<CustomerProductDTO> vm = RequestMakerWrapper.Instance.CustomerProductsByProductId.GetManyById(id);
            return View("Details",vm);
        }
    }
}