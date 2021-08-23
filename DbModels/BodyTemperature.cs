using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SmartWatch.DbModels
{
    [Table("body_temperature")]
    public partial class BodyTemperature
    {
        public BodyTemperature()
        {
            TriggerWarnings = new HashSet<TriggerWarning>();
        }

        [Key]
        [Column("body_temperature_id")]
        public long BodyTemperatureId { get; set; }
        [Column("user_id")]
        public int UserId { get; set; }
        [Column("connect_id")]
        public long? ConnectId { get; set; }
        [Column("temperature")]
        public double Temperature { get; set; }
        [Column("checked_timestamp", TypeName = "datetime")]
        public DateTime CheckedTimestamp { get; set; }
        public bool BodyTemperatureIsDelete { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DeviceTime { get; set; }
        public bool SendNoise { get; set; }
        public bool SendValue { get; set; }
        public bool StopAlarm { get; set; }

        [ForeignKey(nameof(ConnectId))]
        [InverseProperty(nameof(DeviceAssign.BodyTemperatures))]
        public virtual DeviceAssign Connect { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty("BodyTemperatures")]
        public virtual User User { get; set; }
        [InverseProperty(nameof(TriggerWarning.Temp))]
        public virtual ICollection<TriggerWarning> TriggerWarnings { get; set; }
    }
}
