using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("invoice_line")]
[Index("InvoiceId", Name = "idx_invoice_line_invoice")]
public partial class InvoiceLine
{
    [Key]
    [Column("invoice_line_id", TypeName = "int(11)")]
    public int InvoiceLineId { get; set; }

    [Column("invoice_id", TypeName = "int(11)")]
    public int? InvoiceId { get; set; }

    [Column("source_type")]
    [StringLength(50)]
    public string? SourceType { get; set; }

    [Column("source_id", TypeName = "int(11)")]
    public int? SourceId { get; set; }

    [Column("amount")]
    [Precision(10, 2)]
    public decimal? Amount { get; set; }

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    [ForeignKey("InvoiceId")]
    [InverseProperty("InvoiceLines")]
    public virtual Invoice? Invoice { get; set; }
}
