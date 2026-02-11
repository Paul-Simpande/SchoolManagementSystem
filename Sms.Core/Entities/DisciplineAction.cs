using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("discipline_action")]
[Index("ApprovedBy", Name = "approved_by")]
[Index("ReportId", Name = "report_id")]
public partial class DisciplineAction
{
    [Key]
    [Column("action_id", TypeName = "int(11)")]
    public int ActionId { get; set; }

    [Column("report_id", TypeName = "int(11)")]
    public int ReportId { get; set; }

    [Column("action_taken", TypeName = "text")]
    public string? ActionTaken { get; set; }

    [Column("approved_by", TypeName = "int(11)")]
    public int? ApprovedBy { get; set; }

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    [ForeignKey("ApprovedBy")]
    [InverseProperty("DisciplineActions")]
    public virtual AppUser? ApprovedByNavigation { get; set; }

    [ForeignKey("ReportId")]
    [InverseProperty("DisciplineActions")]
    public virtual MisconductReport Report { get; set; } = null!;
}
