using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("academic_term")]
[Index("AcademicYearId", "TermName", Name = "academic_year_id", IsUnique = true)]
public partial class AcademicTerm
{
    [Key]
    [Column("term_id", TypeName = "int(11)")]
    public int TermId { get; set; }

    [Column("academic_year_id", TypeName = "int(11)")]
    public int AcademicYearId { get; set; }

    [Column("term_name")]
    [StringLength(50)]
    public string? TermName { get; set; }

    [Column("start_date")]
    public DateOnly StartDate { get; set; }

    [Column("end_date")]
    public DateOnly EndDate { get; set; }

    [Column("is_active")]
    public bool IsActive { get; set; }

    [ForeignKey("AcademicYearId")]
    [InverseProperty("AcademicTerms")]
    public virtual AcademicYear AcademicYear { get; set; } = null!;
}
