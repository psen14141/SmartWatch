using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SmartWatch.DbModels
{
    [Table("BloodPressure")]
    public partial class BloodPressure
    {
        public BloodPressure()
        {
            TriggerWarnings = new HashSet<TriggerWarning>();
        }

        [Key]
        public long BloodPressureId { get; set; }
        [Column("userId")]
        public int UserId { get; set; }
        public long? ConnectionId { get; set; }
        [Column("checkedtime", TypeName = "datetime")]
        public DateTime Checkedtime { get; set; }
        public double BloodPressureUpper { get; set; }
        public double BloodPreesureLower { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DeviceTime { get; set; }
        public bool SendNoise { get; set; }
        public bool SendValue { get; set; }
        public bool StopAlarm { get; set; }

        [ForeignKey(nameof(ConnectionId))]
        [InverseProperty(nameof(DeviceAssign.BloodPressures))]
        public virtual DeviceAssign Connection { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty("BloodPressures")]
        public virtual User User { get; set; }
        [InverseProperty(nameof(TriggerWarning.BloodPressure))]
        public virtual ICollection<TriggerWarning> TriggerWarnings { get; set; }
    }
}
