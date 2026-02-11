using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("assignment_grade")]
[Index("GradedByTeacherId", Name = "graded_by_teacher_id")]
[Index("SubmissionId", Name = "idx_grade_submission")]
public partial class AssignmentGrade
{
    [Key]
    [Column("grade_id", TypeName = "int(11)")]
    public int GradeId { get; set; }

    [Column("submission_id", TypeName = "int(11)")]
    public int SubmissionId { get; set; }

    [Column("graded_by_teacher_id", TypeName = "int(11)")]
    public int GradedByTeacherId { get; set; }

    [Column("score")]
    [Precision(5, 2)]
    public decimal? Score { get; set; }

    [Column("feedback", TypeName = "text")]
    public string? Feedback { get; set; }

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    [ForeignKey("GradedByTeacherId")]
    [InverseProperty("AssignmentGrades")]
    public virtual Teacher GradedByTeacher { get; set; } = null!;

    [ForeignKey("SubmissionId")]
    [InverseProperty("AssignmentGrades")]
    public virtual AssignmentSubmission Submission { get; set; } = null!;
}
