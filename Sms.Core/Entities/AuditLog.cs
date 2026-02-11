using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("audit_log")]
[Index("ActionTime", Name = "idx_audit_log_time")]
[Index("UserId", Name = "idx_audit_log_user")]
public partial class AuditLog
{
    [Key]
    [Column("audit_log_id", TypeName = "int(11)")]
    public int AuditLogId { get; set; }

    [Column("user_id", TypeName = "int(11)")]
    public int? UserId { get; set; }

    [Column("action")]
    [StringLength(255)]
    public string? Action { get; set; }

    [Column("action_time", TypeName = "datetime")]
    public DateTime? ActionTime { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("AuditLogs")]
    public virtual AppUser? User { get; set; }
}
