using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace Repository.Interfaces
{
    public interface IMeterPointRepository : IRepository<MeterPoint>
    {
        //Can add methods specific to MeterPoint here like below

        //IEnumerable<Meter> GetMetersForMeterPoint(object Id);
    }
}
