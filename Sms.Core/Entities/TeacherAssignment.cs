using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("teacher_assignment")]
[Index("AcademicYearId", Name = "academic_year_id")]
[Index("ClassroomId", Name = "idx_teacher_assignment_classroom")]
[Index("SubjectId", Name = "idx_teacher_assignment_subject")]
[Index("TeacherId", Name = "idx_teacher_assignment_teacher")]
[Index("TeacherId", "ClassroomId", "SubjectId", "AcademicYearId", Name = "teacher_id", IsUnique = true)]
public partial class TeacherAssignment
{
    [Key]
    [Column("teacher_assignment_id", TypeName = "int(11)")]
    public int TeacherAssignmentId { get; set; }

    [Column("teacher_id", TypeName = "int(11)")]
    public int TeacherId { get; set; }

    [Column("classroom_id", TypeName = "int(11)")]
    public int ClassroomId { get; set; }

    [Column("subject_id", TypeName = "int(11)")]
    public int SubjectId { get; set; }

    [Column("academic_year_id", TypeName = "int(11)")]
    public int AcademicYearId { get; set; }

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    [ForeignKey("AcademicYearId")]
    [InverseProperty("TeacherAssignments")]
    public virtual AcademicYear AcademicYear { get; set; } = null!;

    [ForeignKey("ClassroomId")]
    [InverseProperty("TeacherAssignments")]
    public virtual Classroom Classroom { get; set; } = null!;

    [ForeignKey("SubjectId")]
    [InverseProperty("TeacherAssignments")]
    public virtual Subject Subject { get; set; } = null!;

    [ForeignKey("TeacherId")]
    [InverseProperty("TeacherAssignments")]
    public virtual Teacher Teacher { get; set; } = null!;
}
