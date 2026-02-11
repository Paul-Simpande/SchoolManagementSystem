using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("transport_route")]
[Index("SchoolId", Name = "idx_route_school")]
public partial class TransportRoute
{
    [Key]
    [Column("route_id", TypeName = "int(11)")]
    public int RouteId { get; set; }

    [Column("school_id", TypeName = "int(11)")]
    public int? SchoolId { get; set; }

    [Column("route_name")]
    [StringLength(100)]
    public string? RouteName { get; set; }

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    [Column("is_deleted")]
    public bool? IsDeleted { get; set; }

    [Column("deleted_at", TypeName = "datetime")]
    public DateTime? DeletedAt { get; set; }

    [ForeignKey("SchoolId")]
    [InverseProperty("TransportRoutes")]
    public virtual School? School { get; set; }

    [InverseProperty("Route")]
    public virtual ICollection<StudentTransport> StudentTransports { get; set; } = new List<StudentTransport>();

    [InverseProperty("Route")]
    public virtual ICollection<TransportFee> TransportFees { get; set; } = new List<TransportFee>();
}
