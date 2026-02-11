using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("security_incident")]
[Index("UserId", Name = "user_id")]
public partial class SecurityIncident
{
    [Key]
    [Column("incident_id", TypeName = "int(11)")]
    public int IncidentId { get; set; }

    [Column("user_id", TypeName = "int(11)")]
    public int? UserId { get; set; }

    [Column("incident_type")]
    [StringLength(100)]
    public string? IncidentType { get; set; }

    [Column("description", TypeName = "text")]
    public string? Description { get; set; }

    [Column("detected_at", TypeName = "datetime")]
    public DateTime? DetectedAt { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("SecurityIncidents")]
    public virtual AppUser? User { get; set; }
}
