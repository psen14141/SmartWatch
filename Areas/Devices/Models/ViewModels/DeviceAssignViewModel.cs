using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartWatch.DbModels;

namespace SmartWatch.Areas.Devices.Models.ViewModels
{
    public class DeviceAssignViewModel
    {

        public List<DbModels.DeviceAssign> Targetdevice { get; set; } = new List<DbModels.DeviceAssign>();

        public long ConnectNo { get; set; }
        public int DeviceId { get; set; }
        public int UserId { get; set; }
        public DateTime AssignDateStart { get; set; }
        public DateTime? AssignDateEnd { get; set; }
        public bool DeviceAssignIsDelete { get; set; }

        public string Username { get; set; }

        public List<User> users { get; set; } = new List<User>();

        public List<Device> devicestype { get; set; } = new List<Device>();

        public DbModels.Device assignslist { get; set; }
    }
}
