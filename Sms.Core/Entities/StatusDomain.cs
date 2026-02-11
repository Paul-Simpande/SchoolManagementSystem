using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("status_domain")]
[Index("DomainName", Name = "domain_name", IsUnique = true)]
public partial class StatusDomain
{
    [Key]
    [Column("domain_id", TypeName = "int(11)")]
    public int DomainId { get; set; }

    [Column("domain_name")]
    [StringLength(100)]
    public string DomainName { get; set; } = null!;

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("is_active")]
    public bool? IsActive { get; set; }

    [InverseProperty("StatusDomain")]
    public virtual ICollection<StatusChangeLog> StatusChangeLogs { get; set; } = new List<StatusChangeLog>();

    [InverseProperty("Domain")]
    public virtual ICollection<StatusTransition> StatusTransitions { get; set; } = new List<StatusTransition>();
}
