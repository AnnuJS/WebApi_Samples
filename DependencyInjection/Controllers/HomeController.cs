using DependencyInjection.Models;
using DependencyInjection.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        //private ITimeService _NormalDI; AJtodo
        private ISingletonService _singleton;
        private IScopedService _scoped;
        private ITransientService _transient;

        public HomeController(
            ISingletonService singleton,
            IScopedService scoped,
            ITransientService transient)
        {
            _singleton = singleton;
            _scoped = scoped;
            _transient = transient;
        }

        public IActionResult Index()
        {
            var NoDIService = new TimeService();
            return View("Index", NoDIService.GetCurrentTime() + " & Seconds: " + NoDIService.GetCurrentSeconds() );
        }

        public IActionResult SingletonDI()
        {
            return View("SingletonDI", _singleton.GetGuid());
        }

        public IActionResult ScopedDI()
        {
            return View("ScopedDI", _scoped.GetGuid());
        }

        public IActionResult TransientDI()
        {
            return View("TransientDI", _transient.GetGuid());
        }

        //public IActionResult OldDI()
        //{
        //    var NoDIService = new TimeService();
        //    return View("Index", NoDIService.GetCurrentTime() + " & Seconds: " + NoDIService.GetCurrentSeconds());
        //}

        //public IActionResult ScopedDI()
        //{
        //    var NoDIService = new TimeService();
        //    return View("Index", NoDIService.GetCurrentTime() + " & Seconds: " + NoDIService.GetCurrentSeconds());
        //}

        //public IActionResult TransientDI()
        //{
        //    var NoDIService = new TimeService();
        //    return View("Index", NoDIService.GetCurrentTime() + " & Seconds: " + NoDIService.GetCurrentSeconds());
        //}

        //public IActionResult SingletonDI()
        //{
        //    var NoDIService = new TimeService();
        //    return View("Index", NoDIService.GetCurrentTime() + " & Seconds: " + NoDIService.GetCurrentSeconds());
        //}



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
