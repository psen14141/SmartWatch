using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SmartWatch.DbModels
{
    [Table("device-assign")]
    public partial class DeviceAssign
    {
        public DeviceAssign()
        {
            BloodPressures = new HashSet<BloodPressure>();
            BodyTemperatures = new HashSet<BodyTemperature>();
            ConnectionStatuses = new HashSet<ConnectionStatus>();
            HeartRates = new HashSet<HeartRate>();
            StepCounts = new HashSet<StepCount>();
        }

        [Key]
        [Column("connect_no")]
        public long ConnectNo { get; set; }
        [Column("device_id")]
        public int DeviceId { get; set; }
        [Column("user_id")]
        public int UserId { get; set; }
        [Column("assignDateStart", TypeName = "datetime")]
        public DateTime AssignDateStart { get; set; }
        [Column("assignDateEnd", TypeName = "datetime")]
        public DateTime? AssignDateEnd { get; set; }
        public bool DeviceAssignIsDelete { get; set; }

        [ForeignKey(nameof(DeviceId))]
        [InverseProperty("DeviceAssigns")]
        public virtual Device Device { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty("DeviceAssigns")]
        public virtual User User { get; set; }
        [InverseProperty(nameof(BloodPressure.Connection))]
        public virtual ICollection<BloodPressure> BloodPressures { get; set; }
        [InverseProperty(nameof(BodyTemperature.Connect))]
        public virtual ICollection<BodyTemperature> BodyTemperatures { get; set; }
        [InverseProperty(nameof(ConnectionStatus.Connect))]
        public virtual ICollection<ConnectionStatus> ConnectionStatuses { get; set; }
        [InverseProperty(nameof(HeartRate.Connection))]
        public virtual ICollection<HeartRate> HeartRates { get; set; }
        [InverseProperty(nameof(StepCount.Connection))]
        public virtual ICollection<StepCount> StepCounts { get; set; }
    }
}
