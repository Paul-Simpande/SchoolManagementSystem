using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("academic_year")]
[Index("IsActive", Name = "idx_academic_year_active")]
[Index("SchoolId", Name = "idx_academic_year_school")]
[Index("SchoolId", "YearName", Name = "school_id", IsUnique = true)]
public partial class AcademicYear
{
    [Key]
    [Column("academic_year_id", TypeName = "int(11)")]
    public int AcademicYearId { get; set; }

    [Column("school_id", TypeName = "int(11)")]
    public int SchoolId { get; set; }

    [Column("year_name")]
    [StringLength(50)]
    public string YearName { get; set; } = null!;

    [Column("start_date")]
    public DateOnly StartDate { get; set; }

    [Column("end_date")]
    public DateOnly EndDate { get; set; }

    [Column("is_active")]
    public bool? IsActive { get; set; }

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    [InverseProperty("AcademicYear")]
    public virtual ICollection<AcademicResult> AcademicResults { get; set; } = new List<AcademicResult>();

    [InverseProperty("AcademicYear")]
    public virtual ICollection<AcademicTerm> AcademicTerms { get; set; } = new List<AcademicTerm>();

    [InverseProperty("AcademicYear")]
    public virtual ICollection<Assignment> Assignments { get; set; } = new List<Assignment>();

    [InverseProperty("AcademicYear")]
    public virtual ICollection<AttendanceCorrection> AttendanceCorrections { get; set; } = new List<AttendanceCorrection>();

    [InverseProperty("AcademicYear")]
    public virtual ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();

    [InverseProperty("AcademicYear")]
    public virtual ICollection<Budget> Budgets { get; set; } = new List<Budget>();

    [InverseProperty("AcademicYear")]
    public virtual ICollection<Classroom> Classrooms { get; set; } = new List<Classroom>();

    [InverseProperty("AcademicYear")]
    public virtual ICollection<Exam> Exams { get; set; } = new List<Exam>();

    [InverseProperty("AcademicYear")]
    public virtual ICollection<FeeStructure> FeeStructures { get; set; } = new List<FeeStructure>();

    [InverseProperty("AcademicYear")]
    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    [InverseProperty("AcademicYear")]
    public virtual ICollection<LessonPlan> LessonPlans { get; set; } = new List<LessonPlan>();

    [InverseProperty("AcademicYear")]
    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    [ForeignKey("SchoolId")]
    [InverseProperty("AcademicYears")]
    public virtual School School { get; set; } = null!;

    [InverseProperty("AcademicYear")]
    public virtual ICollection<StudentEnrollment> StudentEnrollments { get; set; } = new List<StudentEnrollment>();

    [InverseProperty("AcademicYear")]
    public virtual ICollection<StudentMeal> StudentMeals { get; set; } = new List<StudentMeal>();

    [InverseProperty("AcademicYear")]
    public virtual ICollection<StudentTransport> StudentTransports { get; set; } = new List<StudentTransport>();

    [InverseProperty("AcademicYear")]
    public virtual ICollection<StudyMaterial> StudyMaterials { get; set; } = new List<StudyMaterial>();

    [InverseProperty("AcademicYear")]
    public virtual ICollection<TeacherAssignment> TeacherAssignments { get; set; } = new List<TeacherAssignment>();

    [InverseProperty("AcademicYear")]
    public virtual ICollection<TeacherPerformance> TeacherPerformances { get; set; } = new List<TeacherPerformance>();
}
