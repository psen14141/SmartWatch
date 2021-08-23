using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SmartWatch.DbModels
{
    [Table("connection-status")]
    public partial class ConnectionStatus
    {
        [Key]
        [Column("connectionstatus_id")]
        public int ConnectionstatusId { get; set; }
        [Column("connect_id")]
        public long ConnectId { get; set; }
        [Required]
        [Column("status")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("sync_periodStartTime", TypeName = "datetime")]
        public DateTime SyncPeriodStartTime { get; set; }
        [Column("sync_periodEndTime", TypeName = "datetime")]
        public DateTime? SyncPeriodEndTime { get; set; }

        [ForeignKey(nameof(ConnectId))]
        [InverseProperty(nameof(DeviceAssign.ConnectionStatuses))]
        public virtual DeviceAssign Connect { get; set; }
    }
}
