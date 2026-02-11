using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("status_transition_role")]
[Index("RoleId", Name = "role_id")]
[Index("TransitionId", "RoleId", Name = "transition_id", IsUnique = true)]
public partial class StatusTransitionRole
{
    [Key]
    [Column("transition_role_id", TypeName = "int(11)")]
    public int TransitionRoleId { get; set; }

    [Column("transition_id", TypeName = "int(11)")]
    public int TransitionId { get; set; }

    [Column("role_id", TypeName = "int(11)")]
    public int RoleId { get; set; }

    [ForeignKey("RoleId")]
    [InverseProperty("StatusTransitionRoles")]
    public virtual Role Role { get; set; } = null!;

    [ForeignKey("TransitionId")]
    [InverseProperty("StatusTransitionRoles")]
    public virtual StatusTransition Transition { get; set; } = null!;
}
