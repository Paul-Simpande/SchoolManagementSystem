using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("purchase_order")]
[Index("PaymentStatusId", Name = "idx_po_payment_status")]
[Index("StatusId", Name = "idx_po_status")]
[Index("SupplierId", Name = "idx_po_supplier")]
[Index("PoNumber", Name = "po_number", IsUnique = true)]
[Index("ProcurementRequestId", Name = "procurement_request_id")]
[Index("ReceivedBy", Name = "received_by")]
public partial class PurchaseOrder
{
    [Key]
    [Column("purchase_order_id", TypeName = "int(11)")]
    public int PurchaseOrderId { get; set; }

    [Column("procurement_request_id", TypeName = "int(11)")]
    public int ProcurementRequestId { get; set; }

    [Column("supplier_id", TypeName = "int(11)")]
    public int SupplierId { get; set; }

    [Column("po_number")]
    [StringLength(50)]
    public string PoNumber { get; set; } = null!;

    [Column("order_date")]
    public DateOnly OrderDate { get; set; }

    [Column("expected_delivery_date")]
    public DateOnly? ExpectedDeliveryDate { get; set; }

    [Column("actual_delivery_date")]
    public DateOnly? ActualDeliveryDate { get; set; }

    [Column("total_amount")]
    [Precision(12, 2)]
    public decimal TotalAmount { get; set; }

    [Column("status_id", TypeName = "int(11)")]
    public int StatusId { get; set; }

    [Column("payment_status_id", TypeName = "int(11)")]
    public int PaymentStatusId { get; set; }

    [Column("received_by", TypeName = "int(11)")]
    public int? ReceivedBy { get; set; }

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    [Column("is_deleted")]
    public bool? IsDeleted { get; set; }

    [Column("deleted_at", TypeName = "datetime")]
    public DateTime? DeletedAt { get; set; }

    [InverseProperty("PurchaseOrder")]
    public virtual ICollection<GoodsReceived> GoodsReceiveds { get; set; } = new List<GoodsReceived>();

    [ForeignKey("PaymentStatusId")]
    [InverseProperty("PurchaseOrders")]
    public virtual PaymentStatus PaymentStatus { get; set; } = null!;

    [ForeignKey("ProcurementRequestId")]
    [InverseProperty("PurchaseOrders")]
    public virtual ProcurementRequest ProcurementRequest { get; set; } = null!;

    [ForeignKey("ReceivedBy")]
    [InverseProperty("PurchaseOrders")]
    public virtual AppUser? ReceivedByNavigation { get; set; }

    [ForeignKey("StatusId")]
    [InverseProperty("PurchaseOrders")]
    public virtual PurchaseOrderStatus Status { get; set; } = null!;

    [ForeignKey("SupplierId")]
    [InverseProperty("PurchaseOrders")]
    public virtual Supplier Supplier { get; set; } = null!;
}
