using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SmartWatch.DbModels
{
    [Table("Illness")]
    public partial class Illness
    {
        public Illness()
        {
            SymptomIllnesses = new HashSet<SymptomIllness>();
        }

        [Key]
        public int IllNessId { get; set; }
        [Required]
        [StringLength(100)]
        public string IllNessName { get; set; }
        [StringLength(250)]
        public string IllnessDescription { get; set; }

        [InverseProperty(nameof(SymptomIllness.Illness))]
        public virtual ICollection<SymptomIllness> SymptomIllnesses { get; set; }
    }
}
