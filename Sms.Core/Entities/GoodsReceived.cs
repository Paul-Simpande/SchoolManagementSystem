using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("goods_received")]
[Index("PurchaseOrderId", Name = "idx_grn_po")]
[Index("ReceivedBy", Name = "received_by")]
public partial class GoodsReceived
{
    [Key]
    [Column("grn_id", TypeName = "int(11)")]
    public int GrnId { get; set; }

    [Column("purchase_order_id", TypeName = "int(11)")]
    public int PurchaseOrderId { get; set; }

    [Column("received_by", TypeName = "int(11)")]
    public int ReceivedBy { get; set; }

    [Column("received_date", TypeName = "datetime")]
    public DateTime? ReceivedDate { get; set; }

    [Column("remarks", TypeName = "text")]
    public string? Remarks { get; set; }

    [ForeignKey("PurchaseOrderId")]
    [InverseProperty("GoodsReceiveds")]
    public virtual PurchaseOrder PurchaseOrder { get; set; } = null!;

    [ForeignKey("ReceivedBy")]
    [InverseProperty("GoodsReceiveds")]
    public virtual AppUser ReceivedByNavigation { get; set; } = null!;
}
