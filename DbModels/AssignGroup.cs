using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SmartWatch.DbModels
{
    [Keyless]
    [Table("assign-group")]
    public partial class AssignGroup
    {
        [Column("assign_id")]
        public long AssignId { get; set; }
        [Column("group_id")]
        public int GroupId { get; set; }
        [Column("user_id")]
        public int UserId { get; set; }
        [Column("timestamp", TypeName = "datetime")]
        public DateTime Timestamp { get; set; }
        public bool AssignGroupIsDelete { get; set; }

        [ForeignKey(nameof(GroupId))]
        public virtual MessageGroup Group { get; set; }
        [ForeignKey(nameof(UserId))]
        public virtual User User { get; set; }
    }
}
