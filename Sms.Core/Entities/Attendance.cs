using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("attendance")]
[Index("AcademicYearId", Name = "academic_year_id")]
[Index("AttendanceDate", Name = "idx_attendance_date")]
[Index("StatusId", Name = "idx_attendance_status")]
[Index("StudentId", Name = "idx_attendance_student")]
[Index("StudentId", "TimetableSlotId", "AttendanceDate", Name = "student_id", IsUnique = true)]
[Index("TimetableSlotId", Name = "timetable_slot_id")]
public partial class Attendance
{
    [Key]
    [Column("attendance_id", TypeName = "int(11)")]
    public int AttendanceId { get; set; }

    [Column("student_id", TypeName = "int(11)")]
    public int StudentId { get; set; }

    [Column("timetable_slot_id", TypeName = "int(11)")]
    public int TimetableSlotId { get; set; }

    [Column("academic_year_id", TypeName = "int(11)")]
    public int AcademicYearId { get; set; }

    [Column("status_id", TypeName = "int(11)")]
    public int StatusId { get; set; }

    [Column("attendance_date")]
    public DateOnly AttendanceDate { get; set; }

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    [ForeignKey("AcademicYearId")]
    [InverseProperty("Attendances")]
    public virtual AcademicYear AcademicYear { get; set; } = null!;

    [InverseProperty("Attendance")]
    public virtual ICollection<AttendanceCorrection> AttendanceCorrections { get; set; } = new List<AttendanceCorrection>();

    [ForeignKey("StatusId")]
    [InverseProperty("Attendances")]
    public virtual AttendanceStatus Status { get; set; } = null!;

    [ForeignKey("StudentId")]
    [InverseProperty("Attendances")]
    public virtual Student Student { get; set; } = null!;

    [ForeignKey("TimetableSlotId")]
    [InverseProperty("Attendances")]
    public virtual TimetableSlot TimetableSlot { get; set; } = null!;
}
