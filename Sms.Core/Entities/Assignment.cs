using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("assignment")]
[Index("AcademicYearId", Name = "academic_year_id")]
[Index("ClassroomId", Name = "idx_assignment_classroom")]
[Index("TeacherId", Name = "idx_assignment_teacher")]
[Index("SubjectId", Name = "subject_id")]
public partial class Assignment
{
    [Key]
    [Column("assignment_id", TypeName = "int(11)")]
    public int AssignmentId { get; set; }

    [Column("teacher_id", TypeName = "int(11)")]
    public int TeacherId { get; set; }

    [Column("classroom_id", TypeName = "int(11)")]
    public int ClassroomId { get; set; }

    [Column("subject_id", TypeName = "int(11)")]
    public int SubjectId { get; set; }

    [Column("academic_year_id", TypeName = "int(11)")]
    public int AcademicYearId { get; set; }

    [Column("title")]
    [StringLength(150)]
    public string? Title { get; set; }

    [Column("description", TypeName = "text")]
    public string? Description { get; set; }

    [Column("due_date")]
    public DateOnly? DueDate { get; set; }

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    [Column("is_deleted")]
    public bool? IsDeleted { get; set; }

    [Column("deleted_at", TypeName = "datetime")]
    public DateTime? DeletedAt { get; set; }

    [ForeignKey("AcademicYearId")]
    [InverseProperty("Assignments")]
    public virtual AcademicYear AcademicYear { get; set; } = null!;

    [InverseProperty("Assignment")]
    public virtual ICollection<AssignmentFile> AssignmentFiles { get; set; } = new List<AssignmentFile>();

    [InverseProperty("Assignment")]
    public virtual ICollection<AssignmentSubmission> AssignmentSubmissions { get; set; } = new List<AssignmentSubmission>();

    [ForeignKey("ClassroomId")]
    [InverseProperty("Assignments")]
    public virtual Classroom Classroom { get; set; } = null!;

    [ForeignKey("SubjectId")]
    [InverseProperty("Assignments")]
    public virtual Subject Subject { get; set; } = null!;

    [ForeignKey("TeacherId")]
    [InverseProperty("Assignments")]
    public virtual Teacher Teacher { get; set; } = null!;
}
