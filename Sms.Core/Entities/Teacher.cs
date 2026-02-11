using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("teacher")]
[Index("SchoolId", Name = "idx_teacher_school")]
[Index("UserId", Name = "user_id", IsUnique = true)]
public partial class Teacher
{
    [Key]
    [Column("teacher_id", TypeName = "int(11)")]
    public int TeacherId { get; set; }

    [Column("user_id", TypeName = "int(11)")]
    public int UserId { get; set; }

    [Column("school_id", TypeName = "int(11)")]
    public int SchoolId { get; set; }

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    [Column("is_deleted")]
    public bool? IsDeleted { get; set; }

    [Column("deleted_at", TypeName = "datetime")]
    public DateTime? DeletedAt { get; set; }

    [InverseProperty("GradedByTeacher")]
    public virtual ICollection<AssignmentGrade> AssignmentGrades { get; set; } = new List<AssignmentGrade>();

    [InverseProperty("Teacher")]
    public virtual ICollection<Assignment> Assignments { get; set; } = new List<Assignment>();

    [InverseProperty("Teacher")]
    public virtual ICollection<LeaveRequest> LeaveRequests { get; set; } = new List<LeaveRequest>();

    [InverseProperty("Teacher")]
    public virtual ICollection<LessonPlan> LessonPlans { get; set; } = new List<LessonPlan>();

    [InverseProperty("GradedByTeacher")]
    public virtual ICollection<Mark> Marks { get; set; } = new List<Mark>();

    [InverseProperty("Teacher")]
    public virtual ICollection<MisconductReport> MisconductReports { get; set; } = new List<MisconductReport>();

    [InverseProperty("Teacher")]
    public virtual ICollection<ResourceRequest> ResourceRequests { get; set; } = new List<ResourceRequest>();

    [ForeignKey("SchoolId")]
    [InverseProperty("Teachers")]
    public virtual School School { get; set; } = null!;

    [InverseProperty("RecordedByTeacher")]
    public virtual ICollection<StudentBehaviour> StudentBehaviours { get; set; } = new List<StudentBehaviour>();

    [InverseProperty("Teacher")]
    public virtual ICollection<StudyMaterial> StudyMaterials { get; set; } = new List<StudyMaterial>();

    [InverseProperty("Teacher")]
    public virtual ICollection<TeacherAssignment> TeacherAssignments { get; set; } = new List<TeacherAssignment>();

    [InverseProperty("Teacher")]
    public virtual ICollection<TeacherPerformance> TeacherPerformances { get; set; } = new List<TeacherPerformance>();

    [InverseProperty("Teacher")]
    public virtual ICollection<TimetableSlot> TimetableSlots { get; set; } = new List<TimetableSlot>();

    [ForeignKey("UserId")]
    [InverseProperty("Teacher")]
    public virtual AppUser User { get; set; } = null!;
}
