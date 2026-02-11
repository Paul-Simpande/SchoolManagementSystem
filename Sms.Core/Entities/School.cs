using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("school")]
[Index("StatusId", Name = "status_id")]
public partial class School
{
    [Key]
    [Column("school_id", TypeName = "int(11)")]
    public int SchoolId { get; set; }

    [Column("school_name")]
    [StringLength(150)]
    public string SchoolName { get; set; } = null!;

    [Column("emis_number")]
    [StringLength(50)]
    public string? EmisNumber { get; set; }

    [Column("ecz_center_number")]
    [StringLength(50)]
    public string? EczCenterNumber { get; set; }

    [Column("school_type")]
    [StringLength(50)]
    public string? SchoolType { get; set; }

    [Column("address", TypeName = "text")]
    public string? Address { get; set; }

    [Column("district")]
    [StringLength(100)]
    public string? District { get; set; }

    [Column("province")]
    [StringLength(100)]
    public string? Province { get; set; }

    [Column("country")]
    [StringLength(100)]
    public string? Country { get; set; }

    [Column("website")]
    [StringLength(150)]
    public string? Website { get; set; }

    [Column("status_id", TypeName = "int(11)")]
    public int StatusId { get; set; }

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    [InverseProperty("School")]
    public virtual ICollection<AcademicYear> AcademicYears { get; set; } = new List<AcademicYear>();

    [InverseProperty("School")]
    public virtual ICollection<AdmissionApplication> AdmissionApplications { get; set; } = new List<AdmissionApplication>();

    [InverseProperty("School")]
    public virtual ICollection<Announcement> Announcements { get; set; } = new List<Announcement>();

    [InverseProperty("School")]
    public virtual ICollection<AppUser> AppUsers { get; set; } = new List<AppUser>();

    [InverseProperty("School")]
    public virtual ICollection<Backup> Backups { get; set; } = new List<Backup>();

    [InverseProperty("School")]
    public virtual ICollection<Budget> Budgets { get; set; } = new List<Budget>();

    [InverseProperty("School")]
    public virtual ICollection<Classroom> Classrooms { get; set; } = new List<Classroom>();

    [InverseProperty("School")]
    public virtual ICollection<EventCalendar> EventCalendars { get; set; } = new List<EventCalendar>();

    [InverseProperty("School")]
    public virtual ICollection<Exam> Exams { get; set; } = new List<Exam>();

    [InverseProperty("School")]
    public virtual ICollection<FeeStructure> FeeStructures { get; set; } = new List<FeeStructure>();

    [InverseProperty("School")]
    public virtual ICollection<InventoryItem> InventoryItems { get; set; } = new List<InventoryItem>();

    [InverseProperty("School")]
    public virtual ICollection<MealPlan> MealPlans { get; set; } = new List<MealPlan>();

    [InverseProperty("School")]
    public virtual ICollection<Parent> Parents { get; set; } = new List<Parent>();

    [InverseProperty("School")]
    public virtual ICollection<ProcurementRequest> ProcurementRequests { get; set; } = new List<ProcurementRequest>();

    [InverseProperty("School")]
    public virtual ICollection<SchoolContact> SchoolContacts { get; set; } = new List<SchoolContact>();

    [ForeignKey("StatusId")]
    [InverseProperty("Schools")]
    public virtual SchoolStatus Status { get; set; } = null!;

    [InverseProperty("School")]
    public virtual ICollection<Student> Students { get; set; } = new List<Student>();

    [InverseProperty("School")]
    public virtual ICollection<Subject> Subjects { get; set; } = new List<Subject>();

    [InverseProperty("School")]
    public virtual ICollection<Supplier> Suppliers { get; set; } = new List<Supplier>();

    [InverseProperty("School")]
    public virtual ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();

    [InverseProperty("School")]
    public virtual ICollection<TenantSetting> TenantSettings { get; set; } = new List<TenantSetting>();

    [InverseProperty("School")]
    public virtual TenantSubscription? TenantSubscription { get; set; }

    [InverseProperty("School")]
    public virtual ICollection<TransportFee> TransportFees { get; set; } = new List<TransportFee>();

    [InverseProperty("School")]
    public virtual ICollection<TransportRoute> TransportRoutes { get; set; } = new List<TransportRoute>();

    [InverseProperty("School")]
    public virtual ICollection<Transport> Transports { get; set; } = new List<Transport>();
}
