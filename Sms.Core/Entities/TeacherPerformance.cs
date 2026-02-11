using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("teacher_performance")]
[Index("TeacherId", Name = "idx_teacher_performance_teacher")]
[Index("AcademicYearId", Name = "idx_teacher_performance_year")]
public partial class TeacherPerformance
{
    [Key]
    [Column("performance_id", TypeName = "int(11)")]
    public int PerformanceId { get; set; }

    [Column("teacher_id", TypeName = "int(11)")]
    public int? TeacherId { get; set; }

    [Column("academic_year_id", TypeName = "int(11)")]
    public int? AcademicYearId { get; set; }

    [Column("score")]
    [Precision(5, 2)]
    public decimal? Score { get; set; }

    [ForeignKey("AcademicYearId")]
    [InverseProperty("TeacherPerformances")]
    public virtual AcademicYear? AcademicYear { get; set; }

    [ForeignKey("TeacherId")]
    [InverseProperty("TeacherPerformances")]
    public virtual Teacher? Teacher { get; set; }
}
