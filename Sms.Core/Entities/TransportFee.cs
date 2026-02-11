using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("transport_fee")]
[Index("CycleId", Name = "cycle_id")]
[Index("RouteId", Name = "route_id")]
[Index("SchoolId", Name = "school_id")]
public partial class TransportFee
{
    [Key]
    [Column("transport_fee_id", TypeName = "int(11)")]
    public int TransportFeeId { get; set; }

    [Column("school_id", TypeName = "int(11)")]
    public int? SchoolId { get; set; }

    [Column("route_id", TypeName = "int(11)")]
    public int? RouteId { get; set; }

    [Column("cycle_id", TypeName = "int(11)")]
    public int? CycleId { get; set; }

    [Column("amount")]
    [Precision(10, 2)]
    public decimal? Amount { get; set; }

    [ForeignKey("CycleId")]
    [InverseProperty("TransportFees")]
    public virtual BillingCycle? Cycle { get; set; }

    [ForeignKey("RouteId")]
    [InverseProperty("TransportFees")]
    public virtual TransportRoute? Route { get; set; }

    [ForeignKey("SchoolId")]
    [InverseProperty("TransportFees")]
    public virtual School? School { get; set; }
}
