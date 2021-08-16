using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Routing_Helpers.Controllers
{
    public class EmployeeController : Controller
    {
        //[Route("employee/details/{id:int}/{deptId:int?}")]
        [Route("employee/details/{id}/{deptId}")]
        public IActionResult Index(int id, int deptId)
        {
            return View();
        }
    }
}
