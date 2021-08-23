using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SmartWatch.DbModels
{
    [Table("alert_box")]
    public partial class AlertBox
    {
        [Key]
        [Column("alert_id")]
        public long AlertId { get; set; }
        [Required]
        [Column("title")]
        [StringLength(100)]
        public string Title { get; set; }
        [Required]
        [Column("message_body")]
        [StringLength(100)]
        public string MessageBody { get; set; }
        [Column("message_groupid")]
        public int MessageGroupid { get; set; }
        [Column("timestamp", TypeName = "datetime")]
        public DateTime Timestamp { get; set; }
        public bool AlertIsDelete { get; set; }

        [ForeignKey(nameof(MessageGroupid))]
        [InverseProperty("AlertBoxes")]
        public virtual MessageGroup MessageGroup { get; set; }
    }
}
