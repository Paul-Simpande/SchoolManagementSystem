using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("procurement_request")]
[Index("ApprovedBy", Name = "approved_by")]
[Index("RequestedBy", Name = "idx_procurement_requester")]
[Index("SchoolId", Name = "idx_procurement_school")]
[Index("StatusId", Name = "idx_procurement_status")]
[Index("SupplierId", Name = "idx_procurement_supplier")]
public partial class ProcurementRequest
{
    [Key]
    [Column("procurement_request_id", TypeName = "int(11)")]
    public int ProcurementRequestId { get; set; }

    [Column("school_id", TypeName = "int(11)")]
    public int SchoolId { get; set; }

    [Column("supplier_id", TypeName = "int(11)")]
    public int? SupplierId { get; set; }

    [Column("request_title")]
    [StringLength(200)]
    public string RequestTitle { get; set; } = null!;

    [Column("justification", TypeName = "text")]
    public string? Justification { get; set; }

    [Column("total_estimated_cost")]
    [Precision(12, 2)]
    public decimal? TotalEstimatedCost { get; set; }

    [Column("requested_by", TypeName = "int(11)")]
    public int RequestedBy { get; set; }

    [Column("approved_by", TypeName = "int(11)")]
    public int? ApprovedBy { get; set; }

    [Column("approved_at", TypeName = "datetime")]
    public DateTime? ApprovedAt { get; set; }

    [Column("status_id", TypeName = "int(11)")]
    public int StatusId { get; set; }

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    [Column("is_deleted")]
    public bool? IsDeleted { get; set; }

    [Column("deleted_at", TypeName = "datetime")]
    public DateTime? DeletedAt { get; set; }

    [ForeignKey("ApprovedBy")]
    [InverseProperty("ProcurementRequestApprovedByNavigations")]
    public virtual AppUser? ApprovedByNavigation { get; set; }

    [InverseProperty("ProcurementRequest")]
    public virtual ICollection<ProcurementApprovalLog> ProcurementApprovalLogs { get; set; } = new List<ProcurementApprovalLog>();

    [InverseProperty("ProcurementRequest")]
    public virtual ICollection<ProcurementItem> ProcurementItems { get; set; } = new List<ProcurementItem>();

    [InverseProperty("ProcurementRequest")]
    public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; } = new List<PurchaseOrder>();

    [ForeignKey("RequestedBy")]
    [InverseProperty("ProcurementRequestRequestedByNavigations")]
    public virtual AppUser RequestedByNavigation { get; set; } = null!;

    [ForeignKey("SchoolId")]
    [InverseProperty("ProcurementRequests")]
    public virtual School School { get; set; } = null!;

    [ForeignKey("StatusId")]
    [InverseProperty("ProcurementRequests")]
    public virtual RequestStatus Status { get; set; } = null!;

    [ForeignKey("SupplierId")]
    [InverseProperty("ProcurementRequests")]
    public virtual Supplier? Supplier { get; set; }
}
