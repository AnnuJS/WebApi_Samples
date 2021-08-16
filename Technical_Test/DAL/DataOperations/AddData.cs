using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.DataOperations
{
    public class AddData
    {
        //writing functions to add all data only at the moment
        public static List<Meter> AddDataToMeter()
        {

            return new List<Meter>() {
        new Meter() { MeterType = "Gas", NumberOfRegisters = "2", OperatingMode = "Credit" },
        new Meter() { MeterType = "Electric", NumberOfRegisters = "2", OperatingMode = "Credit" }
        };

        }
        public static List<MeterPoint> AddDataToMeterPoint(List<Meter> Meters)
        {
            return new List<MeterPoint>() {
        new MeterPoint() { Mpan = "123456", MpanIndicator = "1", Meters = Meters },
        new MeterPoint() { Mpan = "7891234", MpanIndicator = "1", Meters = Meters },
        new MeterPoint() { Mpan = "8887828", MpanIndicator = "1", Meters = Meters },
        new MeterPoint() { Mpan = "2165265", MpanIndicator = "1", Meters = Meters }
        };
        }
    }
}