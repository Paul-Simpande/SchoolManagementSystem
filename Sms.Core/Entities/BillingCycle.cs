using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("billing_cycle")]
[Index("CycleName", Name = "cycle_name", IsUnique = true)]
public partial class BillingCycle
{
    [Key]
    [Column("cycle_id", TypeName = "int(11)")]
    public int CycleId { get; set; }

    [Column("cycle_name")]
    [StringLength(50)]
    public string CycleName { get; set; } = null!;

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("is_active")]
    public bool? IsActive { get; set; }

    [InverseProperty("Cycle")]
    public virtual ICollection<TransportFee> TransportFees { get; set; } = new List<TransportFee>();
}
