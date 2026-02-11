using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("authentication_log")]
[Index("LoginTime", Name = "idx_auth_log_time")]
[Index("UserId", Name = "idx_auth_log_user")]
public partial class AuthenticationLog
{
    [Key]
    [Column("auth_log_id", TypeName = "int(11)")]
    public int AuthLogId { get; set; }

    [Column("user_id", TypeName = "int(11)")]
    public int? UserId { get; set; }

    [Column("login_time", TypeName = "datetime")]
    public DateTime? LoginTime { get; set; }

    [Column("success")]
    public bool? Success { get; set; }

    [Column("ip_address")]
    [StringLength(45)]
    public string? IpAddress { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("AuthenticationLogs")]
    public virtual AppUser? User { get; set; }
}
