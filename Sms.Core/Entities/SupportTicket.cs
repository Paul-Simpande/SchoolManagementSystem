using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("support_ticket")]
[Index("IsDeleted", Name = "idx_support_ticket_deleted")]
[Index("StatusId", Name = "idx_support_ticket_status")]
[Index("UserId", Name = "idx_support_ticket_user")]
public partial class SupportTicket
{
    [Key]
    [Column("ticket_id", TypeName = "int(11)")]
    public int TicketId { get; set; }

    [Column("user_id", TypeName = "int(11)")]
    public int? UserId { get; set; }

    [Column("issue_title")]
    [StringLength(150)]
    public string? IssueTitle { get; set; }

    [Column("description", TypeName = "text")]
    public string? Description { get; set; }

    [Column("status_id", TypeName = "int(11)")]
    public int StatusId { get; set; }

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    [Column("is_deleted")]
    public bool? IsDeleted { get; set; }

    [Column("deleted_at", TypeName = "datetime")]
    public DateTime? DeletedAt { get; set; }

    [Column("resolved_at", TypeName = "datetime")]
    public DateTime? ResolvedAt { get; set; }

    [ForeignKey("StatusId")]
    [InverseProperty("SupportTickets")]
    public virtual TicketStatus Status { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("SupportTickets")]
    public virtual AppUser? User { get; set; }
}
