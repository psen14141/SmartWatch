using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartWatch.DbModels;

namespace SmartWatch.Areas.Devices.Models.ViewModels
{
    public class ConnectionStatusViewModel
    {
        public int ConnectionstatusId { get; set; }
        public long ConnectId { get; set; }
        public string Status { get; set; }
        public DateTime SyncPeriodStartTime { get; set; }
        public DateTime? SyncPeriodEndTime { get; set; }

        public List<DeviceAssign> userstypes { get; set; } = new List<DeviceAssign>();
    }
}
