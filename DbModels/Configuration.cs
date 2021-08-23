using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SmartWatch.DbModels
{
    [Table("Configuration")]
    public partial class Configuration
    {
        public Configuration()
        {
            UserConfigurations = new HashSet<UserConfiguration>();
        }

        [Key]
        public int ConfigurationId { get; set; }
        [Required]
        [StringLength(250)]
        public string ConfigurationString { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal ConfigurationValue { get; set; }
        [StringLength(250)]
        public string StringValue { get; set; }

        [InverseProperty(nameof(UserConfiguration.Configuration))]
        public virtual ICollection<UserConfiguration> UserConfigurations { get; set; }
    }
}
