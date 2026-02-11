using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("system_resource_metric")]
public partial class SystemResourceMetric
{
    [Key]
    [Column("metric_id", TypeName = "int(11)")]
    public int MetricId { get; set; }

    [Column("metric_date", TypeName = "datetime")]
    public DateTime? MetricDate { get; set; }

    [Column("cpu_usage")]
    [Precision(5, 2)]
    public decimal? CpuUsage { get; set; }

    [Column("memory_usage")]
    [Precision(5, 2)]
    public decimal? MemoryUsage { get; set; }

    [Column("storage_usage")]
    [Precision(5, 2)]
    public decimal? StorageUsage { get; set; }
}
