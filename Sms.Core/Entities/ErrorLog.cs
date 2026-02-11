using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("error_log")]
[Index("SeverityId", Name = "idx_error_severity")]
public partial class ErrorLog
{
    [Key]
    [Column("error_id", TypeName = "int(11)")]
    public int ErrorId { get; set; }

    [Column("error_time", TypeName = "datetime")]
    public DateTime? ErrorTime { get; set; }

    [Column("error_message", TypeName = "text")]
    public string? ErrorMessage { get; set; }

    [Column("severity_id", TypeName = "int(11)")]
    public int SeverityId { get; set; }

    [ForeignKey("SeverityId")]
    [InverseProperty("ErrorLogs")]
    public virtual ErrorSeverity Severity { get; set; } = null!;
}
