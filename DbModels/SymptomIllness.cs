using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SmartWatch.DbModels
{
    [Table("SymptomIllness")]
    public partial class SymptomIllness
    {
        [Key]
        public long SymptomIllnessId { get; set; }
        public int IllnessId { get; set; }
        public long SymptomId { get; set; }

        [ForeignKey(nameof(IllnessId))]
        [InverseProperty("SymptomIllnesses")]
        public virtual Illness Illness { get; set; }
        [ForeignKey(nameof(SymptomId))]
        [InverseProperty("SymptomIllnesses")]
        public virtual Symptom Symptom { get; set; }
    }
}
