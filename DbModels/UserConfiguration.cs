using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SmartWatch.DbModels
{
    [Table("UserConfiguration")]
    public partial class UserConfiguration
    {
        [Key]
        public int UserConfigurationId { get; set; }
        public int ConfigurationId { get; set; }
        public int UserId { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal Value { get; set; }
        [StringLength(250)]
        public string StringValue { get; set; }

        [ForeignKey(nameof(ConfigurationId))]
        [InverseProperty("UserConfigurations")]
        public virtual Configuration Configuration { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty("UserConfigurations")]
        public virtual User User { get; set; }
    }
}
