using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWatch.Areas.BdyTemperature.Models
{
    public class BodyTemperatureAPIRequest
    {

        public int DeviceId { get; set; }
        public double Temperature { get; set; }
        public DateTime DiviceTime { get; set; }
        public int UserId { get; set; }
        public long? ConnectId { get; set; }
        public string DeviceCode { get; set; }
    }
}
