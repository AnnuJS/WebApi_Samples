using DAL.Models;
using DAL.DataOperations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace WebApi.UnitTest
{
    [TestClass]
    public class MeterPointsUnitTest
    {
        [TestMethod]
        public void TestGet()
        {
            //Arrangement
            Meter meter1;
            Meter meter2;
            MeterPoint meterPoint1;
            MeterPoint meterPoint2;

            List<Meter> meters = new List<Meter>();
            List<MeterPoint> meterPoints = new List<MeterPoint>();
            

            //Action
            meter1 = new Meter { MeterType = "Gas", NumberOfRegisters = "1", OperatingMode = "credit" };
            meter2 = new Meter { MeterType = "Electric", NumberOfRegisters = "1", OperatingMode = "credit" };
            meters.Add(meter1);
            meters.Add(meter2);

            meterPoint1 = new MeterPoint {Mpan="123456", MpanIndicator="1", Meters= meters};
            meterPoint2 = new MeterPoint { Mpan = "789234", MpanIndicator = "1", Meters = meters };
            meterPoints.Add(meterPoint1);
            meterPoints.Add(meterPoint2);

            //Assert
            CollectionAssert.Contains(DAL.DataOperations.SelectData.SelectAllMeterPoints(meterPoints), meterPoint2);

        }
    }
}
