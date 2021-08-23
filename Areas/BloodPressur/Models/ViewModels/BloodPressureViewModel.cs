using SmartWatch.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWatch.Areas.BloodPressur.Models.ViewModels
{
    public partial class BloodPressureViewModel
    {
        public BloodPressureViewModel()
        {
            TriggerWarnings = new HashSet<TriggerWarning>();
        }

        public long BloodPressureId { get; set; }
        public int UserId { get; set; }

        public string Username { get; set; }

        public long? ConnectionId { get; set; }
        public DateTime Checkedtime { get; set; }
        public double BloodPressureUpper { get; set; }
        public double BloodPreesureLower { get; set; }
        public DateTime DeviceTime { get; set; }

        public string fromdate { get; set; }

        public string todate { get; set; }

        public virtual DeviceAssign Connection { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<TriggerWarning> TriggerWarnings { get; set; }



        public string username { get; set; }

        public List<User> Users { get; set; } = new List<User>();
        public List<BloodPressure> bloodPressures { get; set; } = new List<BloodPressure>();
    }
}
