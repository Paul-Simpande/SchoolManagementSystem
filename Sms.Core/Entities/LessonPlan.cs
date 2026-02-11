using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("lesson_plan")]
[Index("AcademicYearId", Name = "academic_year_id")]
[Index("SubjectId", Name = "subject_id")]
[Index("TeacherId", Name = "teacher_id")]
public partial class LessonPlan
{
    [Key]
    [Column("lesson_plan_id", TypeName = "int(11)")]
    public int LessonPlanId { get; set; }

    [Column("teacher_id", TypeName = "int(11)")]
    public int TeacherId { get; set; }

    [Column("subject_id", TypeName = "int(11)")]
    public int SubjectId { get; set; }

    [Column("academic_year_id", TypeName = "int(11)")]
    public int AcademicYearId { get; set; }

    [Column("title")]
    [StringLength(150)]
    public string? Title { get; set; }

    [Column("file_path", TypeName = "text")]
    public string? FilePath { get; set; }

    [Column("uploaded_at", TypeName = "datetime")]
    public DateTime? UploadedAt { get; set; }

    [ForeignKey("AcademicYearId")]
    [InverseProperty("LessonPlans")]
    public virtual AcademicYear AcademicYear { get; set; } = null!;

    [ForeignKey("SubjectId")]
    [InverseProperty("LessonPlans")]
    public virtual Subject Subject { get; set; } = null!;

    [ForeignKey("TeacherId")]
    [InverseProperty("LessonPlans")]
    public virtual Teacher Teacher { get; set; } = null!;
}
