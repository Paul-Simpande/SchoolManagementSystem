using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("academic_result")]
[Index("StudentId", Name = "idx_academic_result_student")]
[Index("AcademicYearId", Name = "idx_academic_result_year")]
[Index("StudentId", "AcademicYearId", Name = "student_id", IsUnique = true)]
public partial class AcademicResult
{
    [Key]
    [Column("academic_result_id", TypeName = "int(11)")]
    public int AcademicResultId { get; set; }

    [Column("student_id", TypeName = "int(11)")]
    public int StudentId { get; set; }

    [Column("academic_year_id", TypeName = "int(11)")]
    public int AcademicYearId { get; set; }

    [Column("average_score")]
    [Precision(5, 2)]
    public decimal? AverageScore { get; set; }

    [Column("final_grade")]
    [StringLength(10)]
    public string? FinalGrade { get; set; }

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    [ForeignKey("AcademicYearId")]
    [InverseProperty("AcademicResults")]
    public virtual AcademicYear AcademicYear { get; set; } = null!;

    [ForeignKey("StudentId")]
    [InverseProperty("AcademicResults")]
    public virtual Student Student { get; set; } = null!;
}
