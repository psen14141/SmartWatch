using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SmartWatch.DbModels
{
    [Table("symptom")]
    public partial class Symptom
    {
        public Symptom()
        {
            SymptomIllnesses = new HashSet<SymptomIllness>();
            TriggerWarnings = new HashSet<TriggerWarning>();
        }

        [Key]
        public long SymptomId { get; set; }
        [Required]
        [Column("symptom")]
        [StringLength(50)]
        public string Symptom1 { get; set; }
        [Column("min_warning")]
        public int MinWarning { get; set; }
        [Column("max_warning")]
        public int MaxWarning { get; set; }
        [Column("timestamp", TypeName = "datetime")]
        public DateTime Timestamp { get; set; }
        [Column("min_warning_Critical")]
        public int? MinWarningCritical { get; set; }
        [Column("max_warning_Critical")]
        public int? MaxWarningCritical { get; set; }
        public int MeasuringId { get; set; }

        [ForeignKey(nameof(MeasuringId))]
        [InverseProperty("Symptoms")]
        public virtual Measuring Measuring { get; set; }
        [InverseProperty(nameof(SymptomIllness.Symptom))]
        public virtual ICollection<SymptomIllness> SymptomIllnesses { get; set; }
        [InverseProperty(nameof(TriggerWarning.Symptom))]
        public virtual ICollection<TriggerWarning> TriggerWarnings { get; set; }
    }
}
