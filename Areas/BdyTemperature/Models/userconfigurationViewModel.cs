using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWatch.Areas.BdyTemperature.Models
{
    public class userconfigurationViewModel
    {



        public int UserConfigurationId { get; set; }
        public int ConfigurationId { get; set; }
        public int UserId { get; set; }
        public decimal Value { get; set; }
        public string StringValue { get; set; }

    }
}
