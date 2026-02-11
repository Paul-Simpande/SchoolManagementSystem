using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("fee_exemption")]
[Index("ApprovedBy", Name = "approved_by")]
[Index("StudentId", Name = "student_id")]
public partial class FeeExemption
{
    [Key]
    [Column("exemption_id", TypeName = "int(11)")]
    public int ExemptionId { get; set; }

    [Column("student_id", TypeName = "int(11)")]
    public int? StudentId { get; set; }

    [Column("amount")]
    [Precision(10, 2)]
    public decimal? Amount { get; set; }

    [Column("reason", TypeName = "text")]
    public string? Reason { get; set; }

    [Column("approved_by", TypeName = "int(11)")]
    public int? ApprovedBy { get; set; }

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    [ForeignKey("ApprovedBy")]
    [InverseProperty("FeeExemptions")]
    public virtual AppUser? ApprovedByNavigation { get; set; }

    [ForeignKey("StudentId")]
    [InverseProperty("FeeExemptions")]
    public virtual Student? Student { get; set; }
}
