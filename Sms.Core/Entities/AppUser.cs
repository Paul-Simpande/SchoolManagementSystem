using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("app_user")]
[Index("Email", Name = "email", IsUnique = true)]
[Index("IsDeleted", Name = "idx_app_user_deleted")]
[Index("SchoolId", Name = "idx_app_user_school")]
[Index("StatusId", Name = "idx_app_user_status")]
public partial class AppUser
{
    [Key]
    [Column("user_id", TypeName = "int(11)")]
    public int UserId { get; set; }

    [Column("school_id", TypeName = "int(11)")]
    public int SchoolId { get; set; }

    [Column("status_id", TypeName = "int(11)")]
    public int StatusId { get; set; }

    [Column("first_name")]
    [StringLength(100)]
    public string? FirstName { get; set; }

    [Column("last_name")]
    [StringLength(100)]
    public string? LastName { get; set; }

    [Column("email")]
    [StringLength(150)]
    public string Email { get; set; } = null!;

    [Column("phone")]
    [StringLength(30)]
    public string? Phone { get; set; }

    [Column("password_hash")]
    [StringLength(255)]
    public string PasswordHash { get; set; } = null!;

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    [Column("is_deleted")]
    public bool? IsDeleted { get; set; }

    [Column("deleted_at", TypeName = "datetime")]
    public DateTime? DeletedAt { get; set; }

    [InverseProperty("ApprovedByNavigation")]
    public virtual ICollection<ApprovalAction> ApprovalActions { get; set; } = new List<ApprovalAction>();

    [InverseProperty("RequestedByNavigation")]
    public virtual ICollection<AttendanceCorrection> AttendanceCorrections { get; set; } = new List<AttendanceCorrection>();

    [InverseProperty("User")]
    public virtual ICollection<AuditLog> AuditLogs { get; set; } = new List<AuditLog>();

    [InverseProperty("User")]
    public virtual ICollection<AuthenticationLog> AuthenticationLogs { get; set; } = new List<AuthenticationLog>();

    [InverseProperty("DeployedByNavigation")]
    public virtual ICollection<DeploymentLog> DeploymentLogs { get; set; } = new List<DeploymentLog>();

    [InverseProperty("ApprovedByNavigation")]
    public virtual ICollection<DisciplineAction> DisciplineActions { get; set; } = new List<DisciplineAction>();

    [InverseProperty("ApprovedByNavigation")]
    public virtual ICollection<FeeExemption> FeeExemptions { get; set; } = new List<FeeExemption>();

    [InverseProperty("ReceivedByNavigation")]
    public virtual ICollection<GoodsReceived> GoodsReceiveds { get; set; } = new List<GoodsReceived>();

    [InverseProperty("Receiver")]
    public virtual ICollection<Notification> NotificationReceivers { get; set; } = new List<Notification>();

    [InverseProperty("Sender")]
    public virtual ICollection<Notification> NotificationSenders { get; set; } = new List<Notification>();

    [InverseProperty("User")]
    public virtual Parent? Parent { get; set; }

    [InverseProperty("User")]
    public virtual ICollection<PasswordReset> PasswordResets { get; set; } = new List<PasswordReset>();

    [InverseProperty("ApprovedByNavigation")]
    public virtual ICollection<ProcurementApprovalLog> ProcurementApprovalLogs { get; set; } = new List<ProcurementApprovalLog>();

    [InverseProperty("ApprovedByNavigation")]
    public virtual ICollection<ProcurementRequest> ProcurementRequestApprovedByNavigations { get; set; } = new List<ProcurementRequest>();

    [InverseProperty("RequestedByNavigation")]
    public virtual ICollection<ProcurementRequest> ProcurementRequestRequestedByNavigations { get; set; } = new List<ProcurementRequest>();

    [InverseProperty("ReceivedByNavigation")]
    public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; } = new List<PurchaseOrder>();

    [ForeignKey("SchoolId")]
    [InverseProperty("AppUsers")]
    public virtual School School { get; set; } = null!;

    [InverseProperty("User")]
    public virtual ICollection<SecurityIncident> SecurityIncidents { get; set; } = new List<SecurityIncident>();

    [ForeignKey("StatusId")]
    [InverseProperty("AppUsers")]
    public virtual UserStatus Status { get; set; } = null!;

    [InverseProperty("ChangedByNavigation")]
    public virtual ICollection<StatusChangeLog> StatusChangeLogs { get; set; } = new List<StatusChangeLog>();

    [InverseProperty("ApprovedByNavigation")]
    public virtual ICollection<StudentEnrollment> StudentEnrollments { get; set; } = new List<StudentEnrollment>();

    [InverseProperty("User")]
    public virtual ICollection<SupportTicket> SupportTickets { get; set; } = new List<SupportTicket>();

    [InverseProperty("User")]
    public virtual Teacher? Teacher { get; set; }

    [InverseProperty("User")]
    public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();

    [InverseProperty("User")]
    public virtual ICollection<UserSession> UserSessions { get; set; } = new List<UserSession>();
}
