using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("system_usage_metric")]
public partial class SystemUsageMetric
{
    [Key]
    [Column("metric_id", TypeName = "int(11)")]
    public int MetricId { get; set; }

    [Column("metric_date", TypeName = "datetime")]
    public DateTime? MetricDate { get; set; }

    [Column("active_users", TypeName = "int(11)")]
    public int? ActiveUsers { get; set; }
}
