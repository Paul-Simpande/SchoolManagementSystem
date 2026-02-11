using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("fact_attendance")]
[Index("DateId", Name = "idx_fact_attendance_date")]
[Index("StudentId", Name = "idx_fact_attendance_student")]
public partial class FactAttendance
{
    [Key]
    [Column("fact_id", TypeName = "int(11)")]
    public int FactId { get; set; }

    [Column("student_id", TypeName = "int(11)")]
    public int? StudentId { get; set; }

    [Column("date_id", TypeName = "int(11)")]
    public int? DateId { get; set; }

    [Column("present_count", TypeName = "int(11)")]
    public int? PresentCount { get; set; }

    [ForeignKey("DateId")]
    [InverseProperty("FactAttendances")]
    public virtual DimDate? Date { get; set; }

    [ForeignKey("StudentId")]
    [InverseProperty("FactAttendances")]
    public virtual Student? Student { get; set; }
}
