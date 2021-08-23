using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SmartWatch.DbModels
{
    [Table("message-group")]
    public partial class MessageGroup
    {
        public MessageGroup()
        {
            AlertBoxes = new HashSet<AlertBox>();
        }

        [Key]
        [Column("group_id")]
        public int GroupId { get; set; }
        [Required]
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; }
        public bool? GroupIsDelete { get; set; }

        [InverseProperty(nameof(AlertBox.MessageGroup))]
        public virtual ICollection<AlertBox> AlertBoxes { get; set; }
    }
}
