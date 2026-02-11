using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Keyless]
public partial class VwProcurementRequestsReceived
{
    [Column("procurement_request_id", TypeName = "int(11)")]
    public int ProcurementRequestId { get; set; }

    [Column("school_id", TypeName = "int(11)")]
    public int SchoolId { get; set; }

    [Column("request_title")]
    [StringLength(200)]
    public string RequestTitle { get; set; } = null!;

    [Column("justification", TypeName = "text")]
    public string? Justification { get; set; }

    [Column("total_estimated_cost")]
    [Precision(12, 2)]
    public decimal? TotalEstimatedCost { get; set; }

    [Column("request_status")]
    [StringLength(50)]
    public string RequestStatus { get; set; } = null!;

    [Column("submitted_at", TypeName = "datetime")]
    public DateTime? SubmittedAt { get; set; }

    [Column("requested_by_id", TypeName = "int(11)")]
    public int RequestedById { get; set; }

    [Column("requested_by_name")]
    [StringLength(201)]
    public string? RequestedByName { get; set; }

    [Column("requester_role")]
    [StringLength(50)]
    public string RequesterRole { get; set; } = null!;
}
