using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("user_session")]
[Index("UserId", Name = "idx_user_session_user")]
public partial class UserSession
{
    [Key]
    [Column("session_id", TypeName = "int(11)")]
    public int SessionId { get; set; }

    [Column("user_id", TypeName = "int(11)")]
    public int UserId { get; set; }

    [Column("login_time", TypeName = "datetime")]
    public DateTime? LoginTime { get; set; }

    [Column("logout_time", TypeName = "datetime")]
    public DateTime? LogoutTime { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("UserSessions")]
    public virtual AppUser User { get; set; } = null!;
}
