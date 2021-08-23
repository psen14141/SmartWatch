using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SmartWatch.DbModels
{
    [Table("trigger-warning")]
    public partial class TriggerWarning
    {
        public TriggerWarning()
        {
            HealthAlerts = new HashSet<HealthAlert>();
        }

        [Key]
        [Column("trigger_id")]
        public long TriggerId { get; set; }
        [Column("profile_id")]
        public int ProfileId { get; set; }
        [Column("heart_rec_id")]
        public long HeartRecId { get; set; }
        [Column("temp_id")]
        public long TempId { get; set; }
        public long SymptomId { get; set; }
        [Required]
        [StringLength(100)]
        public string Status { get; set; }
        public long BloodPressureId { get; set; }
        public bool TriggerWarningIsDelete { get; set; }

        [ForeignKey(nameof(BloodPressureId))]
        [InverseProperty("TriggerWarnings")]
        public virtual BloodPressure BloodPressure { get; set; }
        [ForeignKey(nameof(HeartRecId))]
        [InverseProperty(nameof(HeartRate.TriggerWarnings))]
        public virtual HeartRate HeartRec { get; set; }
        [ForeignKey(nameof(ProfileId))]
        [InverseProperty(nameof(User.TriggerWarnings))]
        public virtual User Profile { get; set; }
        [ForeignKey(nameof(SymptomId))]
        [InverseProperty("TriggerWarnings")]
        public virtual Symptom Symptom { get; set; }
        [ForeignKey(nameof(TempId))]
        [InverseProperty(nameof(BodyTemperature.TriggerWarnings))]
        public virtual BodyTemperature Temp { get; set; }
        [InverseProperty(nameof(HealthAlert.Trigger))]
        public virtual ICollection<HealthAlert> HealthAlerts { get; set; }
    }
}
