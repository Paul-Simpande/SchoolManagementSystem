using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("student")]
[Index("AdmissionNumber", Name = "admission_number", IsUnique = true)]
[Index("EczExamNumber", Name = "ecz_exam_number", IsUnique = true)]
[Index("GenderId", Name = "gender_id")]
[Index("IsDeleted", Name = "idx_student_deleted")]
[Index("SchoolId", Name = "idx_student_school")]
[Index("StatusId", Name = "idx_student_status")]
[Index("SchoolAssignedNumber", Name = "school_assigned_number", IsUnique = true)]
public partial class Student
{
    [Key]
    [Column("student_id", TypeName = "int(11)")]
    public int StudentId { get; set; }

    [Column("school_id", TypeName = "int(11)")]
    public int SchoolId { get; set; }

    [Column("gender_id", TypeName = "int(11)")]
    public int GenderId { get; set; }

    [Column("status_id", TypeName = "int(11)")]
    public int StatusId { get; set; }

    [Column("admission_number")]
    [StringLength(50)]
    public string? AdmissionNumber { get; set; }

    [Column("first_name")]
    [StringLength(100)]
    public string? FirstName { get; set; }

    [Column("last_name")]
    [StringLength(100)]
    public string? LastName { get; set; }

    [Column("date_of_birth")]
    public DateOnly? DateOfBirth { get; set; }

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    [Column("is_deleted")]
    public bool? IsDeleted { get; set; }

    [Column("deleted_at", TypeName = "datetime")]
    public DateTime? DeletedAt { get; set; }

    [Column("ecz_exam_number")]
    [StringLength(50)]
    public string? EczExamNumber { get; set; }

    [Column("school_assigned_number")]
    [StringLength(50)]
    public string? SchoolAssignedNumber { get; set; }

    [InverseProperty("Student")]
    public virtual ICollection<AcademicResult> AcademicResults { get; set; } = new List<AcademicResult>();

    [InverseProperty("Student")]
    public virtual ICollection<AssignmentSubmission> AssignmentSubmissions { get; set; } = new List<AssignmentSubmission>();

    [InverseProperty("Student")]
    public virtual ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();

    [InverseProperty("Student")]
    public virtual ICollection<DimStudent> DimStudents { get; set; } = new List<DimStudent>();

    [InverseProperty("Student")]
    public virtual ICollection<FactAttendance> FactAttendances { get; set; } = new List<FactAttendance>();

    [InverseProperty("Student")]
    public virtual ICollection<FactResult> FactResults { get; set; } = new List<FactResult>();

    [InverseProperty("Student")]
    public virtual ICollection<FeeExemption> FeeExemptions { get; set; } = new List<FeeExemption>();

    [ForeignKey("GenderId")]
    [InverseProperty("Students")]
    public virtual Gender Gender { get; set; } = null!;

    [InverseProperty("Student")]
    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    [InverseProperty("Student")]
    public virtual ICollection<Mark> Marks { get; set; } = new List<Mark>();

    [InverseProperty("Student")]
    public virtual ICollection<MisconductReport> MisconductReports { get; set; } = new List<MisconductReport>();

    [ForeignKey("SchoolId")]
    [InverseProperty("Students")]
    public virtual School School { get; set; } = null!;

    [ForeignKey("StatusId")]
    [InverseProperty("Students")]
    public virtual StudentStatus Status { get; set; } = null!;

    [InverseProperty("Student")]
    public virtual ICollection<StudentBehaviour> StudentBehaviours { get; set; } = new List<StudentBehaviour>();

    [InverseProperty("Student")]
    public virtual ICollection<StudentEnrollment> StudentEnrollments { get; set; } = new List<StudentEnrollment>();

    [InverseProperty("Student")]
    public virtual ICollection<StudentFeeAccount> StudentFeeAccounts { get; set; } = new List<StudentFeeAccount>();

    [InverseProperty("Student")]
    public virtual ICollection<StudentMeal> StudentMeals { get; set; } = new List<StudentMeal>();

    [InverseProperty("Student")]
    public virtual ICollection<StudentParent> StudentParents { get; set; } = new List<StudentParent>();

    [InverseProperty("Student")]
    public virtual ICollection<StudentTransport> StudentTransports { get; set; } = new List<StudentTransport>();
}
