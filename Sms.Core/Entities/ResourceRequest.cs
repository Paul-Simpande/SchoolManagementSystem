using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("resource_request")]
[Index("StatusId", Name = "idx_resource_status")]
[Index("TeacherId", Name = "idx_resource_teacher")]
public partial class ResourceRequest
{
    [Key]
    [Column("resource_request_id", TypeName = "int(11)")]
    public int ResourceRequestId { get; set; }

    [Column("teacher_id", TypeName = "int(11)")]
    public int? TeacherId { get; set; }

    [Column("status_id", TypeName = "int(11)")]
    public int? StatusId { get; set; }

    [Column("resource_name")]
    [StringLength(150)]
    public string? ResourceName { get; set; }

    [ForeignKey("StatusId")]
    [InverseProperty("ResourceRequests")]
    public virtual RequestStatus? Status { get; set; }

    [ForeignKey("TeacherId")]
    [InverseProperty("ResourceRequests")]
    public virtual Teacher? Teacher { get; set; }
}
