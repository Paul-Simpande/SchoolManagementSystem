using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("software_version")]
public partial class SoftwareVersion
{
    [Key]
    [Column("version_id", TypeName = "int(11)")]
    public int VersionId { get; set; }

    [Column("version_number")]
    [StringLength(50)]
    public string? VersionNumber { get; set; }

    [Column("release_date")]
    public DateOnly? ReleaseDate { get; set; }

    [Column("notes", TypeName = "text")]
    public string? Notes { get; set; }

    [InverseProperty("Version")]
    public virtual ICollection<DeploymentLog> DeploymentLogs { get; set; } = new List<DeploymentLog>();
}
