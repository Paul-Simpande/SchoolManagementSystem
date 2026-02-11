using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("password_reset")]
[Index("UserId", Name = "idx_password_reset_user")]
public partial class PasswordReset
{
    [Key]
    [Column("reset_id", TypeName = "int(11)")]
    public int ResetId { get; set; }

    [Column("user_id", TypeName = "int(11)")]
    public int UserId { get; set; }

    [Column("reset_token")]
    [StringLength(255)]
    public string? ResetToken { get; set; }

    [Column("requested_at", TypeName = "datetime")]
    public DateTime? RequestedAt { get; set; }

    [Column("used_at", TypeName = "datetime")]
    public DateTime? UsedAt { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("PasswordResets")]
    public virtual AppUser User { get; set; } = null!;
}
