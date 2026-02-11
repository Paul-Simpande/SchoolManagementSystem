using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("deployment_log")]
[Index("DeployedBy", Name = "idx_deployment_user")]
[Index("VersionId", Name = "idx_deployment_version")]
public partial class DeploymentLog
{
    [Key]
    [Column("deployment_id", TypeName = "int(11)")]
    public int DeploymentId { get; set; }

    [Column("version_id", TypeName = "int(11)")]
    public int? VersionId { get; set; }

    [Column("deployed_by", TypeName = "int(11)")]
    public int? DeployedBy { get; set; }

    [Column("deployed_at", TypeName = "datetime")]
    public DateTime? DeployedAt { get; set; }

    [ForeignKey("DeployedBy")]
    [InverseProperty("DeploymentLogs")]
    public virtual AppUser? DeployedByNavigation { get; set; }

    [ForeignKey("VersionId")]
    [InverseProperty("DeploymentLogs")]
    public virtual SoftwareVersion? Version { get; set; }
}
