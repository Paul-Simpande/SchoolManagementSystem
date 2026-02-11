using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("student_enrollment")]
[Index("ApprovedBy", Name = "approved_by")]
[Index("ClassroomId", Name = "idx_enrollment_classroom")]
[Index("StudentId", Name = "idx_enrollment_student")]
[Index("AcademicYearId", Name = "idx_enrollment_year")]
[Index("StudentId", "AcademicYearId", Name = "student_id", IsUnique = true)]
public partial class StudentEnrollment
{
    [Key]
    [Column("enrollment_id", TypeName = "int(11)")]
    public int EnrollmentId { get; set; }

    [Column("student_id", TypeName = "int(11)")]
    public int StudentId { get; set; }

    [Column("classroom_id", TypeName = "int(11)")]
    public int ClassroomId { get; set; }

    [Column("academic_year_id", TypeName = "int(11)")]
    public int AcademicYearId { get; set; }

    [Column("approved_by", TypeName = "int(11)")]
    public int? ApprovedBy { get; set; }

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    [ForeignKey("AcademicYearId")]
    [InverseProperty("StudentEnrollments")]
    public virtual AcademicYear AcademicYear { get; set; } = null!;

    [ForeignKey("ApprovedBy")]
    [InverseProperty("StudentEnrollments")]
    public virtual AppUser? ApprovedByNavigation { get; set; }

    [ForeignKey("ClassroomId")]
    [InverseProperty("StudentEnrollments")]
    public virtual Classroom Classroom { get; set; } = null!;

    [ForeignKey("StudentId")]
    [InverseProperty("StudentEnrollments")]
    public virtual Student Student { get; set; } = null!;
}
