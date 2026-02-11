using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("mark")]
[Index("GradedByTeacherId", Name = "graded_by_teacher_id")]
[Index("ExamId", Name = "idx_mark_exam")]
[Index("StudentId", Name = "idx_mark_student")]
[Index("StudentId", "SubjectId", "ExamId", Name = "student_id", IsUnique = true)]
[Index("SubjectId", Name = "subject_id")]
public partial class Mark
{
    [Key]
    [Column("mark_id", TypeName = "int(11)")]
    public int MarkId { get; set; }

    [Column("student_id", TypeName = "int(11)")]
    public int StudentId { get; set; }

    [Column("subject_id", TypeName = "int(11)")]
    public int SubjectId { get; set; }

    [Column("exam_id", TypeName = "int(11)")]
    public int ExamId { get; set; }

    [Column("marks")]
    [Precision(5, 2)]
    public decimal? Marks { get; set; }

    [Column("graded_by_teacher_id", TypeName = "int(11)")]
    public int? GradedByTeacherId { get; set; }

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    [ForeignKey("ExamId")]
    [InverseProperty("Marks")]
    public virtual Exam Exam { get; set; } = null!;

    [ForeignKey("GradedByTeacherId")]
    [InverseProperty("Marks")]
    public virtual Teacher? GradedByTeacher { get; set; }

    [ForeignKey("StudentId")]
    [InverseProperty("Marks")]
    public virtual Student Student { get; set; } = null!;

    [ForeignKey("SubjectId")]
    [InverseProperty("Marks")]
    public virtual Subject Subject { get; set; } = null!;
}
