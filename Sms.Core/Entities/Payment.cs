using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("payment")]
[Index("IsDeleted", Name = "idx_payment_deleted")]
[Index("InvoiceId", Name = "idx_payment_invoice")]
[Index("AcademicYearId", Name = "idx_payment_year")]
[Index("PaymentMethodId", Name = "payment_method_id")]
public partial class Payment
{
    [Key]
    [Column("payment_id", TypeName = "int(11)")]
    public int PaymentId { get; set; }

    [Column("invoice_id", TypeName = "int(11)")]
    public int InvoiceId { get; set; }

    [Column("academic_year_id", TypeName = "int(11)")]
    public int AcademicYearId { get; set; }

    [Column("payment_method_id", TypeName = "int(11)")]
    public int? PaymentMethodId { get; set; }

    [Column("amount")]
    [Precision(10, 2)]
    public decimal? Amount { get; set; }

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    [Column("is_deleted")]
    public bool? IsDeleted { get; set; }

    [Column("deleted_at", TypeName = "datetime")]
    public DateTime? DeletedAt { get; set; }

    [ForeignKey("AcademicYearId")]
    [InverseProperty("Payments")]
    public virtual AcademicYear AcademicYear { get; set; } = null!;

    [ForeignKey("InvoiceId")]
    [InverseProperty("Payments")]
    public virtual Invoice Invoice { get; set; } = null!;

    [ForeignKey("PaymentMethodId")]
    [InverseProperty("Payments")]
    public virtual PaymentMethod? PaymentMethod { get; set; }
}
