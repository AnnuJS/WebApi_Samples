using DependencyInjection.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Factory
{
    public class TimeFactory
    {
        public static ITimeService GetTimeObject()
        {
            return new TimeService();
        }
    }
}
