using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("request_status")]
[Index("StatusName", Name = "status_name", IsUnique = true)]
public partial class RequestStatus
{
    [Key]
    [Column("status_id", TypeName = "int(11)")]
    public int StatusId { get; set; }

    [Column("status_name")]
    [StringLength(50)]
    public string StatusName { get; set; } = null!;

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("is_active")]
    public bool? IsActive { get; set; }

    [InverseProperty("Status")]
    public virtual ICollection<LeaveRequest> LeaveRequests { get; set; } = new List<LeaveRequest>();

    [InverseProperty("Status")]
    public virtual ICollection<NotificationLog> NotificationLogs { get; set; } = new List<NotificationLog>();

    [InverseProperty("Status")]
    public virtual ICollection<ProcurementRequest> ProcurementRequests { get; set; } = new List<ProcurementRequest>();

    [InverseProperty("Status")]
    public virtual ICollection<ResourceRequest> ResourceRequests { get; set; } = new List<ResourceRequest>();
}
