using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWatch.Areas.BloodPressur.Models
{
    public class BloodPresureAPIRequest
    {
        public int DeviceId { get; set; }
        public float BloodPresureUpper { get; set; }

        public float BloodPresureLower { get; set; }
        public DateTime DiviceTime { get; set; }

        public string DeviceCode { get; set; }

    }
}
