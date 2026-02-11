using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("approval_action")]
[Index("ApprovedBy", Name = "approved_by")]
[Index("DecisionId", Name = "decision_id")]
[Index("EntityType", "EntityId", Name = "idx_approval_entity")]
public partial class ApprovalAction
{
    [Key]
    [Column("action_id", TypeName = "int(11)")]
    public int ActionId { get; set; }

    [Column("entity_type")]
    [StringLength(50)]
    public string? EntityType { get; set; }

    [Column("entity_id", TypeName = "int(11)")]
    public int? EntityId { get; set; }

    [Column("approved_by", TypeName = "int(11)")]
    public int? ApprovedBy { get; set; }

    [Column("action_date", TypeName = "datetime")]
    public DateTime? ActionDate { get; set; }

    [Column("decision_id", TypeName = "int(11)")]
    public int DecisionId { get; set; }

    [ForeignKey("ApprovedBy")]
    [InverseProperty("ApprovalActions")]
    public virtual AppUser? ApprovedByNavigation { get; set; }

    [ForeignKey("DecisionId")]
    [InverseProperty("ApprovalActions")]
    public virtual ApprovalDecision Decision { get; set; } = null!;
}
