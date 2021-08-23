using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWatch.Areas.SimulatorAPI.Models
{
    public class SimulatorAPIRequest
    {
        public int DeviceId { get; set; }
        public DateTime DiviceTime { get; set; }
        public int UserId { get; set; }
        public double BloodPressureUpper { get; set; }
        public double BloodPressureLower { get; set; }
        public double Temperature { get; set; }
        public double PulseRate { get; set; }
        public long StepCount { get; set; }

        public string DeviceCode { get; set; }
    }
}
