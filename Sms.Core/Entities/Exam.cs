using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("exam")]
[Index("SchoolId", Name = "idx_exam_school")]
[Index("AcademicYearId", Name = "idx_exam_year")]
public partial class Exam
{
    [Key]
    [Column("exam_id", TypeName = "int(11)")]
    public int ExamId { get; set; }

    [Column("school_id", TypeName = "int(11)")]
    public int SchoolId { get; set; }

    [Column("academic_year_id", TypeName = "int(11)")]
    public int AcademicYearId { get; set; }

    [Column("exam_name")]
    [StringLength(100)]
    public string ExamName { get; set; } = null!;

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    [Column("is_deleted")]
    public bool? IsDeleted { get; set; }

    [Column("deleted_at", TypeName = "datetime")]
    public DateTime? DeletedAt { get; set; }

    [ForeignKey("AcademicYearId")]
    [InverseProperty("Exams")]
    public virtual AcademicYear AcademicYear { get; set; } = null!;

    [InverseProperty("Exam")]
    public virtual ICollection<Mark> Marks { get; set; } = new List<Mark>();

    [ForeignKey("SchoolId")]
    [InverseProperty("Exams")]
    public virtual School School { get; set; } = null!;
}
