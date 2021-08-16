using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Routing_Helpers.Controllers
{
    public class ProductController : Controller
    {
        
        public IActionResult Index(int id, int catId)
        {
            return View();
        }
    }
}
