using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWatch.Areas.HeartRatee.Models
{
    public class HeartRateAPIRequest
    {
        public int DeviceId { get; set; }
        public double HeartRate { get; set; }

        public DateTime DiviceTime { get; set; } = DateTime.UtcNow;
        public int UserId { get; set; }
        public long? ConnectId { get; set; }
        public string DeviceCode { get; set; }

        public bool SendNoise { get; set; }
        public bool SendValue { get; set; }
        public bool StopAlarm { get; set; }


    }
}
