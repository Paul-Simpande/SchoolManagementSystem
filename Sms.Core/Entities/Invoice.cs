using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("invoice")]
[Index("IsDeleted", Name = "idx_invoice_deleted")]
[Index("StatusId", Name = "idx_invoice_status")]
[Index("StudentId", Name = "idx_invoice_student")]
[Index("AcademicYearId", Name = "idx_invoice_year")]
public partial class Invoice
{
    [Key]
    [Column("invoice_id", TypeName = "int(11)")]
    public int InvoiceId { get; set; }

    [Column("student_id", TypeName = "int(11)")]
    public int StudentId { get; set; }

    [Column("academic_year_id", TypeName = "int(11)")]
    public int AcademicYearId { get; set; }

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

    [ForeignKey("AcademicYearId")]
    [InverseProperty("Invoices")]
    public virtual AcademicYear AcademicYear { get; set; } = null!;

    [InverseProperty("Invoice")]
    public virtual ICollection<InvoiceLine> InvoiceLines { get; set; } = new List<InvoiceLine>();

    [InverseProperty("Invoice")]
    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    [ForeignKey("StatusId")]
    [InverseProperty("Invoices")]
    public virtual InvoiceStatus Status { get; set; } = null!;

    [ForeignKey("StudentId")]
    [InverseProperty("Invoices")]
    public virtual Student Student { get; set; } = null!;
}
