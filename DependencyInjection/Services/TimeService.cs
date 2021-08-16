using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Services
{
    public class TimeService : ITimeService
    {
        private DateTime _dt;
        public TimeService()
        {
            _dt = DateTime.Now;
        }

        public string GetCurrentSeconds()
        {
            return _dt.Second.ToString();
        }

        public string GetCurrentTime()
        {
            return _dt.ToString();
        }
    }
}
