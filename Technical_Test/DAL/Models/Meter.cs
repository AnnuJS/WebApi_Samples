using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAL.Models
{
    //Calling this class library as DAL to virtually simulate EF
    //If tables from EF were present then could have created another class library only for models
    public class Meter
    {
        //public int MeterID { get; set; } //PK
        public string MeterType { get; set; } //We could have MeterType as a table in itself and have MeterTypeID as FK in this table
        public string NumberOfRegisters { get; set; }
        public string OperatingMode { get; set; } //We could have OperatingMode as a table in itself and have OperatingModeID as FK in this table
    } 
}
