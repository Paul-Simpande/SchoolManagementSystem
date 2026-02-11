using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("tenant_subscription")]
[Index("SchoolId", Name = "school_id", IsUnique = true)]
public partial class TenantSubscription
{
    [Key]
    [Column("subscription_id", TypeName = "int(11)")]
    public int SubscriptionId { get; set; }

    [Column("school_id", TypeName = "int(11)")]
    public int SchoolId { get; set; }

    [Column("plan_name")]
    [StringLength(50)]
    public string? PlanName { get; set; }

    [Column("start_date")]
    public DateOnly? StartDate { get; set; }

    [Column("end_date")]
    public DateOnly? EndDate { get; set; }

    [Column("is_active")]
    public bool? IsActive { get; set; }

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [ForeignKey("SchoolId")]
    [InverseProperty("TenantSubscription")]
    public virtual School School { get; set; } = null!;
}
