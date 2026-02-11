using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("transport")]
[Index("SchoolId", Name = "idx_transport_school")]
public partial class Transport
{
    [Key]
    [Column("transport_id", TypeName = "int(11)")]
    public int TransportId { get; set; }

    [Column("school_id", TypeName = "int(11)")]
    public int? SchoolId { get; set; }

    [Column("vehicle_number")]
    [StringLength(50)]
    public string? VehicleNumber { get; set; }

    [Column("capacity", TypeName = "int(11)")]
    public int? Capacity { get; set; }

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    [Column("is_deleted")]
    public bool? IsDeleted { get; set; }

    [Column("deleted_at", TypeName = "datetime")]
    public DateTime? DeletedAt { get; set; }

    [ForeignKey("SchoolId")]
    [InverseProperty("Transports")]
    public virtual School? School { get; set; }

    [InverseProperty("Transport")]
    public virtual ICollection<StudentTransport> StudentTransports { get; set; } = new List<StudentTransport>();
}
