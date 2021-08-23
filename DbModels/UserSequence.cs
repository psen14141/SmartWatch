using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SmartWatch.DbModels
{
    [Table("UserSequence")]
    public partial class UserSequence
    {
        [Key]
        [Column("UserSequenceID")]
        public long UserSequenceId { get; set; }
        [Column("UserID")]
        public int UserId { get; set; }
        public double ValuesInSeconds { get; set; }
        public bool IsSentBloodPressure { get; set; }
        public bool IsSentStepCount { get; set; }
        public bool IsSentBodyTemperature { get; set; }
        public bool IsSentHeartRate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateTimeSet { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateTimeSend { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty("UserSequences")]
        public virtual User User { get; set; }
    }
}
