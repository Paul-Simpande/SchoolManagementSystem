using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("classroom")]
[Index("SchoolId", Name = "idx_classroom_school")]
[Index("AcademicYearId", Name = "idx_classroom_year")]
[Index("SchoolId", "AcademicYearId", "ClassName", Name = "school_id", IsUnique = true)]
public partial class Classroom
{
    [Key]
    [Column("classroom_id", TypeName = "int(11)")]
    public int ClassroomId { get; set; }

    [Column("school_id", TypeName = "int(11)")]
    public int SchoolId { get; set; }

    [Column("academic_year_id", TypeName = "int(11)")]
    public int AcademicYearId { get; set; }

    [Column("class_name")]
    [StringLength(50)]
    public string ClassName { get; set; } = null!;

    [Column("capacity", TypeName = "int(11)")]
    public int? Capacity { get; set; }

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    [Column("is_deleted")]
    public bool? IsDeleted { get; set; }

    [Column("deleted_at", TypeName = "datetime")]
    public DateTime? DeletedAt { get; set; }

    [ForeignKey("AcademicYearId")]
    [InverseProperty("Classrooms")]
    public virtual AcademicYear AcademicYear { get; set; } = null!;

    [InverseProperty("Classroom")]
    public virtual ICollection<Assignment> Assignments { get; set; } = new List<Assignment>();

    [ForeignKey("SchoolId")]
    [InverseProperty("Classrooms")]
    public virtual School School { get; set; } = null!;

    [InverseProperty("Classroom")]
    public virtual ICollection<StudentEnrollment> StudentEnrollments { get; set; } = new List<StudentEnrollment>();

    [InverseProperty("Classroom")]
    public virtual ICollection<TeacherAssignment> TeacherAssignments { get; set; } = new List<TeacherAssignment>();

    [InverseProperty("Classroom")]
    public virtual ICollection<TimetableSlot> TimetableSlots { get; set; } = new List<TimetableSlot>();
}
