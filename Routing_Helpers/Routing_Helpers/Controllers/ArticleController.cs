using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Routing_Helpers.Controllers
{
    [Route("article")]
    public class ArticleController : Controller
    {
        [Route("~/learn/{cat}/{url}")]
        public IActionResult Index(string cat, string url)
        {
            return View();
        }
    }
}
