using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("notification_log")]
[Index("NotificationId", Name = "idx_notification_log_notification")]
[Index("StatusId", Name = "idx_notification_log_status")]
public partial class NotificationLog
{
    [Key]
    [Column("log_id", TypeName = "int(11)")]
    public int LogId { get; set; }

    [Column("notification_id", TypeName = "int(11)")]
    public int? NotificationId { get; set; }

    [Column("delivered_at", TypeName = "datetime")]
    public DateTime? DeliveredAt { get; set; }

    [Column("status_id", TypeName = "int(11)")]
    public int StatusId { get; set; }

    [ForeignKey("NotificationId")]
    [InverseProperty("NotificationLogs")]
    public virtual Notification? Notification { get; set; }

    [ForeignKey("StatusId")]
    [InverseProperty("NotificationLogs")]
    public virtual RequestStatus Status { get; set; } = null!;
}
