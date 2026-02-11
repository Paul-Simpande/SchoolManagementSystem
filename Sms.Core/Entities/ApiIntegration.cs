using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("api_integration")]
[Index("StatusId", Name = "idx_api_status")]
public partial class ApiIntegration
{
    [Key]
    [Column("api_id", TypeName = "int(11)")]
    public int ApiId { get; set; }

    [Column("service_name")]
    [StringLength(100)]
    public string? ServiceName { get; set; }

    [Column("api_key", TypeName = "text")]
    public string? ApiKey { get; set; }

    [Column("status_id", TypeName = "int(11)")]
    public int StatusId { get; set; }

    [Column("last_checked", TypeName = "datetime")]
    public DateTime? LastChecked { get; set; }

    [ForeignKey("StatusId")]
    [InverseProperty("ApiIntegrations")]
    public virtual IntegrationStatus Status { get; set; } = null!;
}
