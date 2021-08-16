using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using DAL.Models;

namespace WebApi_Technical_Test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MeterReadingController : ControllerBase
    { 
        
        public static List<Meter> Meters = DAL.DataOperations.AddData.AddDataToMeter();
        public static List<MeterPoint> MeterPoints = DAL.DataOperations.AddData.AddDataToMeterPoint(Meters);      

        [HttpGet]
        public IEnumerable<MeterPoint> Get()
        {
            
            return DAL.DataOperations.SelectData.SelectAllMeterPoints(MeterPoints); //OK:200
            
        }
    }
}
