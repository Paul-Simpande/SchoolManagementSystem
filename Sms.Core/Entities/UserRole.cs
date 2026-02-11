using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("user_role")]
[Index("RoleId", Name = "idx_user_role_role")]
[Index("UserId", Name = "idx_user_role_user")]
public partial class UserRole
{
    [Key]
    [Column("user_role_id", TypeName = "int(11)")]
    public int UserRoleId { get; set; }

    [Column("user_id", TypeName = "int(11)")]
    public int UserId { get; set; }

    [Column("role_id", TypeName = "int(11)")]
    public int RoleId { get; set; }

    [ForeignKey("RoleId")]
    [InverseProperty("UserRoles")]
    public virtual Role Role { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("UserRoles")]
    public virtual AppUser User { get; set; } = null!;
}
