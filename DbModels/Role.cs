using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SmartWatch.DbModels
{
    [Table("role")]
    public partial class Role
    {
        public Role()
        {
            Permissions = new HashSet<Permission>();
            Users = new HashSet<User>();
        }

        [Key]
        [Column("role_id")]
        public int RoleId { get; set; }
        [Required]
        [Column("role_name")]
        [StringLength(50)]
        public string RoleName { get; set; }
        [Column("is_active")]
        public bool IsActive { get; set; }
        [Column("is_system")]
        public bool IsSystem { get; set; }
        [Column("is_superadmin")]
        public bool IsSuperadmin { get; set; }
        [Column("is_client_root")]
        public bool IsClientRoot { get; set; }
        [Column("is_client")]
        public bool IsClient { get; set; }
        [Column("created_at", TypeName = "datetime")]
        public DateTime CreatedAt { get; set; }
        [Column("updated_at", TypeName = "datetime")]
        public DateTime UpdatedAt { get; set; }
        public bool RoleIsDelete { get; set; }

        [InverseProperty(nameof(Permission.Role))]
        public virtual ICollection<Permission> Permissions { get; set; }
        [InverseProperty(nameof(User.Role))]
        public virtual ICollection<User> Users { get; set; }
    }
}
