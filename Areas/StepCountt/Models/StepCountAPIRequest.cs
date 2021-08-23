using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWatch.Areas.StepCountt.Models
{
    public class StepCountAPIRequest
    {
        public int DeviceId { get; set; }
        public long StepCount { get; set; }
        public DateTime DiviceTime { get; set; }
   
        public int UserId { get; set; }

        public string DeviceCode { get; set; }


    }
}
