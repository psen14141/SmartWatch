using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SmartWatch.DbModels
{
    [Table("health-alert")]
    public partial class HealthAlert
    {
        [Key]
        [Column("health_alert_id")]
        public long HealthAlertId { get; set; }
        [Column("user_id")]
        public int UserId { get; set; }
        [Column("trigger_id")]
        public long TriggerId { get; set; }
        [Required]
        [StringLength(250)]
        public string Healthstatus { get; set; }
        [Required]
        [StringLength(250)]
        public string ReceiverAlert { get; set; }
        public bool HasSeen { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Alertseentime { get; set; }
        public bool GotAction { get; set; }
        [StringLength(250)]
        public string Response { get; set; }
        public bool HealthAlertIsDelete { get; set; }

        [ForeignKey(nameof(TriggerId))]
        [InverseProperty(nameof(TriggerWarning.HealthAlerts))]
        public virtual TriggerWarning Trigger { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty("HealthAlerts")]
        public virtual User User { get; set; }
    }
}
