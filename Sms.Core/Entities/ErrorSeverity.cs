using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("error_severity")]
[Index("SeverityName", Name = "severity_name", IsUnique = true)]
public partial class ErrorSeverity
{
    [Key]
    [Column("severity_id", TypeName = "int(11)")]
    public int SeverityId { get; set; }

    [Column("severity_name")]
    [StringLength(50)]
    public string SeverityName { get; set; } = null!;

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("is_active")]
    public bool? IsActive { get; set; }

    [InverseProperty("Severity")]
    public virtual ICollection<ErrorLog> ErrorLogs { get; set; } = new List<ErrorLog>();
}
