using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("status_change_log")]
[Index("ChangedBy", Name = "changed_by")]
[Index("EntityType", "EntityId", Name = "idx_status_change_entity")]
[Index("ChangedAt", Name = "idx_status_change_time")]
[Index("StatusDomainId", Name = "status_domain_id")]
public partial class StatusChangeLog
{
    [Key]
    [Column("status_change_id", TypeName = "int(11)")]
    public int StatusChangeId { get; set; }

    [Column("entity_type")]
    [StringLength(50)]
    public string EntityType { get; set; } = null!;

    [Column("entity_id", TypeName = "int(11)")]
    public int EntityId { get; set; }

    [Column("old_status_id", TypeName = "int(11)")]
    public int OldStatusId { get; set; }

    [Column("new_status_id", TypeName = "int(11)")]
    public int NewStatusId { get; set; }

    [Column("status_domain_id", TypeName = "int(11)")]
    public int StatusDomainId { get; set; }

    [Column("changed_by", TypeName = "int(11)")]
    public int ChangedBy { get; set; }

    [Column("changed_at", TypeName = "datetime")]
    public DateTime? ChangedAt { get; set; }

    [Column("remarks", TypeName = "text")]
    public string? Remarks { get; set; }

    [ForeignKey("ChangedBy")]
    [InverseProperty("StatusChangeLogs")]
    public virtual AppUser ChangedByNavigation { get; set; } = null!;

    [ForeignKey("StatusDomainId")]
    [InverseProperty("StatusChangeLogs")]
    public virtual StatusDomain StatusDomain { get; set; } = null!;
}
