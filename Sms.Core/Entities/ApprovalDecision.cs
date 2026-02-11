using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("approval_decision")]
[Index("DecisionName", Name = "decision_name", IsUnique = true)]
public partial class ApprovalDecision
{
    [Key]
    [Column("decision_id", TypeName = "int(11)")]
    public int DecisionId { get; set; }

    [Column("decision_name")]
    [StringLength(50)]
    public string DecisionName { get; set; } = null!;

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("is_active")]
    public bool? IsActive { get; set; }

    [InverseProperty("Decision")]
    public virtual ICollection<ApprovalAction> ApprovalActions { get; set; } = new List<ApprovalAction>();

    [InverseProperty("Decision")]
    public virtual ICollection<ProcurementApprovalLog> ProcurementApprovalLogs { get; set; } = new List<ProcurementApprovalLog>();
}
