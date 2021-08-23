using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SmartWatch.DbModels
{
    [Table("permission")]
    public partial class Permission
    {
        [Key]
        [Column("permission_id")]
        public int PermissionId { get; set; }
        [Column("module_id")]
        public int ModuleId { get; set; }
        [Column("role_id")]
        public int RoleId { get; set; }
        [Column("category_id")]
        public int CategoryId { get; set; }
        [Column("can_view")]
        public bool CanView { get; set; }
        [Column("can_add")]
        public bool CanAdd { get; set; }
        [Column("can_delete")]
        public bool CanDelete { get; set; }
        [Column("created_at", TypeName = "datetime")]
        public DateTime CreatedAt { get; set; }
        public bool PermissionIsDelete { get; set; }

        [ForeignKey(nameof(ModuleId))]
        [InverseProperty("Permissions")]
        public virtual Module Module { get; set; }
        [ForeignKey(nameof(RoleId))]
        [InverseProperty("Permissions")]
        public virtual Role Role { get; set; }
    }
}
