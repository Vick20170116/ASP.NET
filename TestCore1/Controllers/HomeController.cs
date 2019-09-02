using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TestCore1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDiSample _diSample;

        public HomeController(IDiSample diSample)
        {
            _diSample = diSample;
        }

        public string Index()
        {
            return $"[IDiSample]{Environment.NewLine}" +
                   $"Id: {_diSample.Id}{Environment.NewLine}" +
                   $"HashCode: {_diSample.GetHashCode()}{Environment.NewLine}" +
                   $"Type: {_diSample.GetType()}";

        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}