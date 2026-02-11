using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("assignment_submission")]
[Index("AssignmentId", "StudentId", Name = "assignment_id", IsUnique = true)]
[Index("StudentId", Name = "idx_submission_student")]
public partial class AssignmentSubmission
{
    [Key]
    [Column("submission_id", TypeName = "int(11)")]
    public int SubmissionId { get; set; }

    [Column("assignment_id", TypeName = "int(11)")]
    public int AssignmentId { get; set; }

    [Column("student_id", TypeName = "int(11)")]
    public int StudentId { get; set; }

    [Column("file_path", TypeName = "text")]
    public string? FilePath { get; set; }

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    [ForeignKey("AssignmentId")]
    [InverseProperty("AssignmentSubmissions")]
    public virtual Assignment Assignment { get; set; } = null!;

    [InverseProperty("Submission")]
    public virtual ICollection<AssignmentGrade> AssignmentGrades { get; set; } = new List<AssignmentGrade>();

    [ForeignKey("StudentId")]
    [InverseProperty("AssignmentSubmissions")]
    public virtual Student Student { get; set; } = null!;
}
