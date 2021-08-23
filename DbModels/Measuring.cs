using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SmartWatch.DbModels
{
    public partial class Measuring
    {
        public Measuring()
        {
            Symptoms = new HashSet<Symptom>();
        }

        [Key]
        public int MeasuringId { get; set; }
        [Required]
        [StringLength(150)]
        public string MeasuringName { get; set; }
        [Required]
        [StringLength(250)]
        public string MeasuringDescription { get; set; }

        [InverseProperty(nameof(Symptom.Measuring))]
        public virtual ICollection<Symptom> Symptoms { get; set; }
    }
}
