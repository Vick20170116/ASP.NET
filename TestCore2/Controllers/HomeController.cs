using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestCore2.Models;
using TestCore2.Service;

namespace TestCore2.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDiSample _diSample;

        private readonly IDiSample _diTransient;
        private readonly IDiSample _diScoped;
        private readonly IDiSample _diSingleton;

        private readonly ISessionWapper _sessionWapper;

        public HomeController(IDiSampleTransient transient, IDiSampleScoped scoped, IDiSampleSingleton singleton,
            ISessionWapper sessionWapper)
        {
            _diTransient = transient;
            _diScoped = scoped;
            _diSingleton = singleton;

            _sessionWapper = sessionWapper;
        }

        public IActionResult Index()
        {
            ViewBag.TransientId = _diTransient.Id;
            ViewBag.TransientHashCode = _diTransient.GetHashCode();

            ViewBag.ScopedId = _diScoped.Id;
            ViewBag.ScopedHashCode = _diScoped.GetHashCode();

            ViewBag.SingletonId = _diSingleton.Id;
            ViewBag.SingletonHashCode = _diSingleton.GetHashCode();

            return View();
        }

        public IActionResult IndexSession()
        {
            var user = _sessionWapper.User;
            _sessionWapper.User = user;
            return Ok(user);
        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
