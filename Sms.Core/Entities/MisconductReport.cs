using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("misconduct_report")]
[Index("StudentId", Name = "student_id")]
[Index("TeacherId", Name = "teacher_id")]
public partial class MisconductReport
{
    [Key]
    [Column("report_id", TypeName = "int(11)")]
    public int ReportId { get; set; }

    [Column("student_id", TypeName = "int(11)")]
    public int StudentId { get; set; }

    [Column("teacher_id", TypeName = "int(11)")]
    public int TeacherId { get; set; }

    [Column("description", TypeName = "text")]
    public string? Description { get; set; }

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    [InverseProperty("Report")]
    public virtual ICollection<DisciplineAction> DisciplineActions { get; set; } = new List<DisciplineAction>();

    [ForeignKey("StudentId")]
    [InverseProperty("MisconductReports")]
    public virtual Student Student { get; set; } = null!;

    [ForeignKey("TeacherId")]
    [InverseProperty("MisconductReports")]
    public virtual Teacher Teacher { get; set; } = null!;
}
