using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SmartWatch.DbModels
{
    [Table("heart_rate")]
    public partial class HeartRate
    {
        public HeartRate()
        {
            TriggerWarnings = new HashSet<TriggerWarning>();
        }

        [Key]
        [Column("rec_id")]
        public long RecId { get; set; }
        [Column("user_id")]
        public int UserId { get; set; }
        [Column("connection_id")]
        public long? ConnectionId { get; set; }
        [Column("checked_time", TypeName = "datetime")]
        public DateTime CheckedTime { get; set; }
        public double PulseRate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DeviceTime { get; set; }
        public bool SendNoise { get; set; }
        public bool SendValue { get; set; }
        public bool StopAlarm { get; set; }

        [ForeignKey(nameof(ConnectionId))]
        [InverseProperty(nameof(DeviceAssign.HeartRates))]
        public virtual DeviceAssign Connection { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty("HeartRates")]
        public virtual User User { get; set; }
        [InverseProperty(nameof(TriggerWarning.HeartRec))]
        public virtual ICollection<TriggerWarning> TriggerWarnings { get; set; }
    }
}
