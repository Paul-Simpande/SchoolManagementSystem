using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("notification")]
[Index("IsDeleted", Name = "idx_notification_deleted")]
[Index("ReceiverId", Name = "idx_notification_receiver")]
[Index("SenderId", Name = "idx_notification_sender")]
public partial class Notification
{
    [Key]
    [Column("notification_id", TypeName = "int(11)")]
    public int NotificationId { get; set; }

    [Column("sender_id", TypeName = "int(11)")]
    public int? SenderId { get; set; }

    [Column("receiver_id", TypeName = "int(11)")]
    public int? ReceiverId { get; set; }

    [Column("message", TypeName = "text")]
    public string? Message { get; set; }

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    [Column("is_deleted")]
    public bool? IsDeleted { get; set; }

    [Column("deleted_at", TypeName = "datetime")]
    public DateTime? DeletedAt { get; set; }

    [InverseProperty("Notification")]
    public virtual ICollection<NotificationLog> NotificationLogs { get; set; } = new List<NotificationLog>();

    [ForeignKey("ReceiverId")]
    [InverseProperty("NotificationReceivers")]
    public virtual AppUser? Receiver { get; set; }

    [ForeignKey("SenderId")]
    [InverseProperty("NotificationSenders")]
    public virtual AppUser? Sender { get; set; }
}
