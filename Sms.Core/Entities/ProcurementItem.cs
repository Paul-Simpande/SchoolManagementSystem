using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("procurement_item")]
[Index("ProcurementRequestId", Name = "idx_procurement_item_request")]
[Index("InventoryItemId", Name = "inventory_item_id")]
public partial class ProcurementItem
{
    [Key]
    [Column("procurement_item_id", TypeName = "int(11)")]
    public int ProcurementItemId { get; set; }

    [Column("procurement_request_id", TypeName = "int(11)")]
    public int ProcurementRequestId { get; set; }

    [Column("item_name")]
    [StringLength(150)]
    public string ItemName { get; set; } = null!;

    [Column("item_description", TypeName = "text")]
    public string? ItemDescription { get; set; }

    [Column("quantity", TypeName = "int(11)")]
    public int Quantity { get; set; }

    [Column("unit_price")]
    [Precision(10, 2)]
    public decimal UnitPrice { get; set; }

    [Column("total_price")]
    [Precision(12, 2)]
    public decimal? TotalPrice { get; set; }

    [Column("inventory_item_id", TypeName = "int(11)")]
    public int? InventoryItemId { get; set; }

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    [ForeignKey("InventoryItemId")]
    [InverseProperty("ProcurementItems")]
    public virtual InventoryItem? InventoryItem { get; set; }

    [ForeignKey("ProcurementRequestId")]
    [InverseProperty("ProcurementItems")]
    public virtual ProcurementRequest ProcurementRequest { get; set; } = null!;
}
