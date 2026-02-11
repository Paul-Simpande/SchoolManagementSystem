using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("leave_request")]
[Index("StatusId", Name = "idx_leave_status")]
[Index("TeacherId", Name = "idx_leave_teacher")]
public partial class LeaveRequest
{
    [Key]
    [Column("leave_request_id", TypeName = "int(11)")]
    public int LeaveRequestId { get; set; }

    [Column("teacher_id", TypeName = "int(11)")]
    public int? TeacherId { get; set; }

    [Column("status_id", TypeName = "int(11)")]
    public int? StatusId { get; set; }

    [Column("start_date")]
    public DateOnly? StartDate { get; set; }

    [Column("end_date")]
    public DateOnly? EndDate { get; set; }

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    [ForeignKey("StatusId")]
    [InverseProperty("LeaveRequests")]
    public virtual RequestStatus? Status { get; set; }

    [ForeignKey("TeacherId")]
    [InverseProperty("LeaveRequests")]
    public virtual Teacher? Teacher { get; set; }
}
