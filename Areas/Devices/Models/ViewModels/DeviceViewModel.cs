using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartWatch.DbModels;

namespace SmartWatch.Areas.Devices.Models.ViewModels
{
    public class DeviceViewModel
    {
        public int DeviceId { get; set; }
        public string Type { get; set; }
        public DateTime RegDate { get; set; }
        public string DeviceCode { get; set; }
        public bool DeviceIsDelete { get; set; }
    }
}
