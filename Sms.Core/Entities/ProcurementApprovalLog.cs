using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("procurement_approval_log")]
[Index("ApprovedBy", Name = "approved_by")]
[Index("DecisionId", Name = "decision_id")]
[Index("ProcurementRequestId", Name = "procurement_request_id")]
public partial class ProcurementApprovalLog
{
    [Key]
    [Column("approval_log_id", TypeName = "int(11)")]
    public int ApprovalLogId { get; set; }

    [Column("procurement_request_id", TypeName = "int(11)")]
    public int ProcurementRequestId { get; set; }

    [Column("approved_by", TypeName = "int(11)")]
    public int ApprovedBy { get; set; }

    [Column("decision_id", TypeName = "int(11)")]
    public int DecisionId { get; set; }

    [Column("remarks", TypeName = "text")]
    public string? Remarks { get; set; }

    [Column("action_date", TypeName = "datetime")]
    public DateTime? ActionDate { get; set; }

    [ForeignKey("ApprovedBy")]
    [InverseProperty("ProcurementApprovalLogs")]
    public virtual AppUser ApprovedByNavigation { get; set; } = null!;

    [ForeignKey("DecisionId")]
    [InverseProperty("ProcurementApprovalLogs")]
    public virtual ApprovalDecision Decision { get; set; } = null!;

    [ForeignKey("ProcurementRequestId")]
    [InverseProperty("ProcurementApprovalLogs")]
    public virtual ProcurementRequest ProcurementRequest { get; set; } = null!;
}
