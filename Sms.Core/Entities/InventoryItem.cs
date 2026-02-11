using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("inventory_item")]
[Index("SchoolId", Name = "idx_inventory_school")]
public partial class InventoryItem
{
    [Key]
    [Column("inventory_id", TypeName = "int(11)")]
    public int InventoryId { get; set; }

    [Column("school_id", TypeName = "int(11)")]
    public int SchoolId { get; set; }

    [Column("item_name")]
    [StringLength(150)]
    public string ItemName { get; set; } = null!;

    [Column("quantity", TypeName = "int(11)")]
    public int? Quantity { get; set; }

    [Column("unit_price")]
    [Precision(10, 2)]
    public decimal? UnitPrice { get; set; }

    [Column("minimum_stock", TypeName = "int(11)")]
    public int? MinimumStock { get; set; }

    [Column("last_updated_reason")]
    [StringLength(255)]
    public string? LastUpdatedReason { get; set; }

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    [InverseProperty("InventoryItem")]
    public virtual ICollection<ProcurementItem> ProcurementItems { get; set; } = new List<ProcurementItem>();

    [ForeignKey("SchoolId")]
    [InverseProperty("InventoryItems")]
    public virtual School School { get; set; } = null!;
}
