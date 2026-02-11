using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("study_material")]
[Index("AcademicYearId", Name = "academic_year_id")]
[Index("SubjectId", Name = "subject_id")]
[Index("TeacherId", Name = "teacher_id")]
public partial class StudyMaterial
{
    [Key]
    [Column("material_id", TypeName = "int(11)")]
    public int MaterialId { get; set; }

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
    [InverseProperty("StudyMaterials")]
    public virtual AcademicYear AcademicYear { get; set; } = null!;

    [ForeignKey("SubjectId")]
    [InverseProperty("StudyMaterials")]
    public virtual Subject Subject { get; set; } = null!;

    [ForeignKey("TeacherId")]
    [InverseProperty("StudyMaterials")]
    public virtual Teacher Teacher { get; set; } = null!;
}
