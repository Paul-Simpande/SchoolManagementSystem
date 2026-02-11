using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("student_transport")]
[Index("StudentId", Name = "idx_student_transport_student")]
[Index("AcademicYearId", Name = "idx_student_transport_year")]
[Index("RouteId", Name = "route_id")]
[Index("TransportId", Name = "transport_id")]
public partial class StudentTransport
{
    [Key]
    [Column("student_transport_id", TypeName = "int(11)")]
    public int StudentTransportId { get; set; }

    [Column("student_id", TypeName = "int(11)")]
    public int? StudentId { get; set; }

    [Column("transport_id", TypeName = "int(11)")]
    public int? TransportId { get; set; }

    [Column("academic_year_id", TypeName = "int(11)")]
    public int AcademicYearId { get; set; }

    [Column("route_id", TypeName = "int(11)")]
    public int? RouteId { get; set; }

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    [ForeignKey("AcademicYearId")]
    [InverseProperty("StudentTransports")]
    public virtual AcademicYear AcademicYear { get; set; } = null!;

    [ForeignKey("RouteId")]
    [InverseProperty("StudentTransports")]
    public virtual TransportRoute? Route { get; set; }

    [ForeignKey("StudentId")]
    [InverseProperty("StudentTransports")]
    public virtual Student? Student { get; set; }

    [ForeignKey("TransportId")]
    [InverseProperty("StudentTransports")]
    public virtual Transport? Transport { get; set; }
}
