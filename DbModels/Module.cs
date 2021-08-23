using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SmartWatch.DbModels
{
    [Table("module")]
    public partial class Module
    {
        public Module()
        {
            Permissions = new HashSet<Permission>();
        }

        [Key]
        [Column("module_id")]
        public int ModuleId { get; set; }
        [Required]
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [Column("short_code")]
        [StringLength(50)]
        public string ShortCode { get; set; }
        [Column("is_active")]
        public bool IsActive { get; set; }
        [Required]
        [Column("system")]
        [StringLength(50)]
        public string System { get; set; }
        [Required]
        [Column("workshop_id")]
        [StringLength(50)]
        public string WorkshopId { get; set; }
        [Column("created_at", TypeName = "datetime")]
        public DateTime CreatedAt { get; set; }
        public bool ModuleIsDelete { get; set; }

        [InverseProperty(nameof(Permission.Module))]
        public virtual ICollection<Permission> Permissions { get; set; }
    }
}
