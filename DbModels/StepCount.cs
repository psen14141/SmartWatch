using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SmartWatch.DbModels
{
    [Table("step-count")]
    public partial class StepCount
    {
        [Key]
        [Column("step_count_id")]
        public long StepCountId { get; set; }
        [Column("user_id")]
        public int UserId { get; set; }
        [Column("connection_id")]
        public long? ConnectionId { get; set; }
        [Column("steps")]
        public long Steps { get; set; }
        [Column("timestamp", TypeName = "datetime")]
        public DateTime Timestamp { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DeviceTime { get; set; }
        public bool SendNoise { get; set; }
        public bool SendValue { get; set; }
        public bool StopAlarm { get; set; }

        [ForeignKey(nameof(ConnectionId))]
        [InverseProperty(nameof(DeviceAssign.StepCounts))]
        public virtual DeviceAssign Connection { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty("StepCounts")]
        public virtual User User { get; set; }
    }
}
