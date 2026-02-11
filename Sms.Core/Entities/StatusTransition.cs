using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("status_transition")]
[Index("DomainId", "FromStatusId", "ToStatusId", Name = "domain_id", IsUnique = true)]
public partial class StatusTransition
{
    [Key]
    [Column("transition_id", TypeName = "int(11)")]
    public int TransitionId { get; set; }

    [Column("domain_id", TypeName = "int(11)")]
    public int DomainId { get; set; }

    [Column("from_status_id", TypeName = "int(11)")]
    public int FromStatusId { get; set; }

    [Column("to_status_id", TypeName = "int(11)")]
    public int ToStatusId { get; set; }

    [Column("requires_approval")]
    public bool? RequiresApproval { get; set; }

    [Column("is_terminal")]
    public bool? IsTerminal { get; set; }

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [ForeignKey("DomainId")]
    [InverseProperty("StatusTransitions")]
    public virtual StatusDomain Domain { get; set; } = null!;

    [InverseProperty("Transition")]
    public virtual ICollection<StatusTransitionRole> StatusTransitionRoles { get; set; } = new List<StatusTransitionRole>();
}
