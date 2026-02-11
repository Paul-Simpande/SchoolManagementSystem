using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("attendance_correction")]
[Index("AcademicYearId", Name = "academic_year_id")]
[Index("AttendanceId", Name = "idx_attendance_correction_attendance")]
[Index("StatusId", Name = "idx_attendance_correction_status")]
[Index("RequestedBy", Name = "requested_by")]
public partial class AttendanceCorrection
{
    [Key]
    [Column("correction_id", TypeName = "int(11)")]
    public int CorrectionId { get; set; }

    [Column("attendance_id", TypeName = "int(11)")]
    public int? AttendanceId { get; set; }

    [Column("academic_year_id", TypeName = "int(11)")]
    public int AcademicYearId { get; set; }

    [Column("requested_by", TypeName = "int(11)")]
    public int? RequestedBy { get; set; }

    [Column("status_id", TypeName = "int(11)")]
    public int StatusId { get; set; }

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    [ForeignKey("AcademicYearId")]
    [InverseProperty("AttendanceCorrections")]
    public virtual AcademicYear AcademicYear { get; set; } = null!;

    [ForeignKey("AttendanceId")]
    [InverseProperty("AttendanceCorrections")]
    public virtual Attendance? Attendance { get; set; }

    [ForeignKey("RequestedBy")]
    [InverseProperty("AttendanceCorrections")]
    public virtual AppUser? RequestedByNavigation { get; set; }

    [ForeignKey("StatusId")]
    [InverseProperty("AttendanceCorrections")]
    public virtual CorrectionStatus Status { get; set; } = null!;
}
