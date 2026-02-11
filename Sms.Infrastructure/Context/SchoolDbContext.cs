using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Sms.Core.Entities;

namespace Sms.Infrastructure.Context;

public partial class SchoolDbContext : DbContext
{
    public SchoolDbContext(DbContextOptions<SchoolDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AcademicResult> AcademicResults { get; set; }

    public virtual DbSet<AcademicTerm> AcademicTerms { get; set; }

    public virtual DbSet<AcademicYear> AcademicYears { get; set; }

    public virtual DbSet<AdmissionApplication> AdmissionApplications { get; set; }

    public virtual DbSet<AdmissionDocument> AdmissionDocuments { get; set; }

    public virtual DbSet<AdmissionStatus> AdmissionStatuses { get; set; }

    public virtual DbSet<Announcement> Announcements { get; set; }

    public virtual DbSet<ApiIntegration> ApiIntegrations { get; set; }

    public virtual DbSet<AppUser> AppUsers { get; set; }

    public virtual DbSet<ApprovalAction> ApprovalActions { get; set; }

    public virtual DbSet<ApprovalDecision> ApprovalDecisions { get; set; }

    public virtual DbSet<Assignment> Assignments { get; set; }

    public virtual DbSet<AssignmentFile> AssignmentFiles { get; set; }

    public virtual DbSet<AssignmentGrade> AssignmentGrades { get; set; }

    public virtual DbSet<AssignmentSubmission> AssignmentSubmissions { get; set; }

    public virtual DbSet<Attendance> Attendances { get; set; }

    public virtual DbSet<AttendanceCorrection> AttendanceCorrections { get; set; }

    public virtual DbSet<AttendanceStatus> AttendanceStatuses { get; set; }

    public virtual DbSet<AuditLog> AuditLogs { get; set; }

    public virtual DbSet<AuthenticationLog> AuthenticationLogs { get; set; }

    public virtual DbSet<Backup> Backups { get; set; }

    public virtual DbSet<BackupStatus> BackupStatuses { get; set; }

    public virtual DbSet<BillingCycle> BillingCycles { get; set; }

    public virtual DbSet<Budget> Budgets { get; set; }

    public virtual DbSet<BudgetStatus> BudgetStatuses { get; set; }

    public virtual DbSet<Classroom> Classrooms { get; set; }

    public virtual DbSet<CorrectionStatus> CorrectionStatuses { get; set; }

    public virtual DbSet<DayOfWeeks> DayOfWeeks { get; set; }

    public virtual DbSet<DeploymentLog> DeploymentLogs { get; set; }

    public virtual DbSet<DimDate> DimDates { get; set; }

    public virtual DbSet<DimStudent> DimStudents { get; set; }

    public virtual DbSet<DisciplineAction> DisciplineActions { get; set; }

    public virtual DbSet<ErrorLog> ErrorLogs { get; set; }

    public virtual DbSet<ErrorSeverity> ErrorSeverities { get; set; }

    public virtual DbSet<EventCalendar> EventCalendars { get; set; }

    public virtual DbSet<Exam> Exams { get; set; }

    public virtual DbSet<FactAttendance> FactAttendances { get; set; }

    public virtual DbSet<FactResult> FactResults { get; set; }

    public virtual DbSet<FeeExemption> FeeExemptions { get; set; }

    public virtual DbSet<FeeStructure> FeeStructures { get; set; }

    public virtual DbSet<FeeStructureHistory> FeeStructureHistories { get; set; }

    public virtual DbSet<Gender> Genders { get; set; }

    public virtual DbSet<GoodsReceived> GoodsReceiveds { get; set; }

    public virtual DbSet<IntegrationStatus> IntegrationStatuses { get; set; }

    public virtual DbSet<InventoryItem> InventoryItems { get; set; }

    public virtual DbSet<Invoice> Invoices { get; set; }

    public virtual DbSet<InvoiceLine> InvoiceLines { get; set; }

    public virtual DbSet<InvoiceStatus> InvoiceStatuses { get; set; }

    public virtual DbSet<LeaveRequest> LeaveRequests { get; set; }

    public virtual DbSet<LessonPlan> LessonPlans { get; set; }

    public virtual DbSet<Mark> Marks { get; set; }

    public virtual DbSet<MealPlan> MealPlans { get; set; }

    public virtual DbSet<MealSchedule> MealSchedules { get; set; }

    public virtual DbSet<MisconductReport> MisconductReports { get; set; }

    public virtual DbSet<NetworkUptime> NetworkUptimes { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<NotificationLog> NotificationLogs { get; set; }

    public virtual DbSet<Parent> Parents { get; set; }

    public virtual DbSet<PasswordReset> PasswordResets { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }

    public virtual DbSet<PaymentStatus> PaymentStatuses { get; set; }

    public virtual DbSet<Permission> Permissions { get; set; }

    public virtual DbSet<ProcurementApprovalLog> ProcurementApprovalLogs { get; set; }

    public virtual DbSet<ProcurementItem> ProcurementItems { get; set; }

    public virtual DbSet<ProcurementRequest> ProcurementRequests { get; set; }

    public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; }

    public virtual DbSet<PurchaseOrderStatus> PurchaseOrderStatuses { get; set; }

    public virtual DbSet<RequestStatus> RequestStatuses { get; set; }

    public virtual DbSet<ResourceRequest> ResourceRequests { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<School> Schools { get; set; }

    public virtual DbSet<SchoolContact?> SchoolContacts { get; set; }

    public virtual DbSet<SchoolStatus> SchoolStatuses { get; set; }

    public virtual DbSet<SecurityIncident> SecurityIncidents { get; set; }

    public virtual DbSet<SoftwareVersion> SoftwareVersions { get; set; }

    public virtual DbSet<StatusChangeLog> StatusChangeLogs { get; set; }

    public virtual DbSet<StatusDomain> StatusDomains { get; set; }

    public virtual DbSet<StatusTransition> StatusTransitions { get; set; }

    public virtual DbSet<StatusTransitionRole> StatusTransitionRoles { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<StudentBehaviour> StudentBehaviours { get; set; }

    public virtual DbSet<StudentEnrollment> StudentEnrollments { get; set; }

    public virtual DbSet<StudentFeeAccount> StudentFeeAccounts { get; set; }

    public virtual DbSet<StudentMeal> StudentMeals { get; set; }

    public virtual DbSet<StudentParent> StudentParents { get; set; }

    public virtual DbSet<StudentStatus> StudentStatuses { get; set; }

    public virtual DbSet<StudentTransport> StudentTransports { get; set; }

    public virtual DbSet<StudyMaterial> StudyMaterials { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<SupplierStatus> SupplierStatuses { get; set; }

    public virtual DbSet<SupplierType> SupplierTypes { get; set; }

    public virtual DbSet<SupportTicket> SupportTickets { get; set; }

    public virtual DbSet<SystemResourceMetric> SystemResourceMetrics { get; set; }

    public virtual DbSet<SystemUsageMetric> SystemUsageMetrics { get; set; }

    public virtual DbSet<Teacher> Teachers { get; set; }

    public virtual DbSet<TeacherAssignment> TeacherAssignments { get; set; }

    public virtual DbSet<TeacherPerformance> TeacherPerformances { get; set; }

    public virtual DbSet<TenantSetting> TenantSettings { get; set; }

    public virtual DbSet<TenantSubscription> TenantSubscriptions { get; set; }

    public virtual DbSet<TicketStatus> TicketStatuses { get; set; }

    public virtual DbSet<TimetableSlot> TimetableSlots { get; set; }

    public virtual DbSet<Transport> Transports { get; set; }

    public virtual DbSet<TransportFee> TransportFees { get; set; }

    public virtual DbSet<TransportRoute> TransportRoutes { get; set; }

    public virtual DbSet<UptimeStatus> UptimeStatuses { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

    public virtual DbSet<UserSession> UserSessions { get; set; }

    public virtual DbSet<UserStatus> UserStatuses { get; set; }

    public virtual DbSet<VwProcurementRequestsReceived> VwProcurementRequestsReceiveds { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_unicode_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<AcademicResult>(entity =>
        {
            entity.HasKey(e => e.AcademicResultId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.AcademicYear).WithMany(p => p.AcademicResults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("academic_result_ibfk_2");

            entity.HasOne(d => d.Student).WithMany(p => p.AcademicResults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("academic_result_ibfk_1");
        });

        modelBuilder.Entity<AcademicTerm>(entity =>
        {
            entity.HasKey(e => e.TermId).HasName("PRIMARY");

            entity.Property(e => e.IsActive).HasDefaultValueSql("'0'");

            entity.HasOne(d => d.AcademicYear).WithMany(p => p.AcademicTerms)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("academic_term_ibfk_1");
        });

        modelBuilder.Entity<AcademicYear>(entity =>
        {
            entity.HasKey(e => e.AcademicYearId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.IsActive).HasDefaultValueSql("'0'");
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.School).WithMany(p => p.AcademicYears)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("academic_year_ibfk_1");
        });

        modelBuilder.Entity<AdmissionApplication>(entity =>
        {
            entity.HasKey(e => e.ApplicationId).HasName("PRIMARY");

            entity.HasOne(d => d.School).WithMany(p => p.AdmissionApplications).HasConstraintName("admission_application_ibfk_2");

            entity.HasOne(d => d.Status).WithMany(p => p.AdmissionApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("admission_application_ibfk_1");
        });

        modelBuilder.Entity<AdmissionDocument>(entity =>
        {
            entity.HasKey(e => e.DocumentId).HasName("PRIMARY");

            entity.HasOne(d => d.Application).WithMany(p => p.AdmissionDocuments).HasConstraintName("admission_document_ibfk_1");
        });

        modelBuilder.Entity<AdmissionStatus>(entity =>
        {
            entity.HasKey(e => e.StatusId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<Announcement>(entity =>
        {
            entity.HasKey(e => e.AnnouncementId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("'0'");
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.School).WithMany(p => p.Announcements).HasConstraintName("announcement_ibfk_1");
        });

        modelBuilder.Entity<ApiIntegration>(entity =>
        {
            entity.HasKey(e => e.ApiId).HasName("PRIMARY");

            entity.HasOne(d => d.Status).WithMany(p => p.ApiIntegrations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("api_integration_ibfk_1");
        });

        modelBuilder.Entity<AppUser>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("'0'");
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.School).WithMany(p => p.AppUsers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("app_user_ibfk_1");

            entity.HasOne(d => d.Status).WithMany(p => p.AppUsers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("app_user_ibfk_2");
        });

        modelBuilder.Entity<ApprovalAction>(entity =>
        {
            entity.HasKey(e => e.ActionId).HasName("PRIMARY");

            entity.HasOne(d => d.ApprovedByNavigation).WithMany(p => p.ApprovalActions).HasConstraintName("approval_action_ibfk_2");

            entity.HasOne(d => d.Decision).WithMany(p => p.ApprovalActions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("approval_action_ibfk_1");
        });

        modelBuilder.Entity<ApprovalDecision>(entity =>
        {
            entity.HasKey(e => e.DecisionId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<Assignment>(entity =>
        {
            entity.HasKey(e => e.AssignmentId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("'0'");
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.AcademicYear).WithMany(p => p.Assignments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("assignment_ibfk_4");

            entity.HasOne(d => d.Classroom).WithMany(p => p.Assignments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("assignment_ibfk_2");

            entity.HasOne(d => d.Subject).WithMany(p => p.Assignments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("assignment_ibfk_3");

            entity.HasOne(d => d.Teacher).WithMany(p => p.Assignments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("assignment_ibfk_1");
        });

        modelBuilder.Entity<AssignmentFile>(entity =>
        {
            entity.HasKey(e => e.FileId).HasName("PRIMARY");

            entity.Property(e => e.UploadedAt).HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.Assignment).WithMany(p => p.AssignmentFiles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("assignment_file_ibfk_1");
        });

        modelBuilder.Entity<AssignmentGrade>(entity =>
        {
            entity.HasKey(e => e.GradeId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.GradedByTeacher).WithMany(p => p.AssignmentGrades)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("assignment_grade_ibfk_2");

            entity.HasOne(d => d.Submission).WithMany(p => p.AssignmentGrades)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("assignment_grade_ibfk_1");
        });

        modelBuilder.Entity<AssignmentSubmission>(entity =>
        {
            entity.HasKey(e => e.SubmissionId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.Assignment).WithMany(p => p.AssignmentSubmissions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("assignment_submission_ibfk_1");

            entity.HasOne(d => d.Student).WithMany(p => p.AssignmentSubmissions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("assignment_submission_ibfk_2");
        });

        modelBuilder.Entity<Attendance>(entity =>
        {
            entity.HasKey(e => e.AttendanceId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.AcademicYear).WithMany(p => p.Attendances)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("attendance_ibfk_3");

            entity.HasOne(d => d.Status).WithMany(p => p.Attendances)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("attendance_ibfk_4");

            entity.HasOne(d => d.Student).WithMany(p => p.Attendances)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("attendance_ibfk_1");

            entity.HasOne(d => d.TimetableSlot).WithMany(p => p.Attendances)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("attendance_ibfk_2");
        });

        modelBuilder.Entity<AttendanceCorrection>(entity =>
        {
            entity.HasKey(e => e.CorrectionId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.AcademicYear).WithMany(p => p.AttendanceCorrections)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("attendance_correction_ibfk_3");

            entity.HasOne(d => d.Attendance).WithMany(p => p.AttendanceCorrections).HasConstraintName("attendance_correction_ibfk_1");

            entity.HasOne(d => d.RequestedByNavigation).WithMany(p => p.AttendanceCorrections).HasConstraintName("attendance_correction_ibfk_4");

            entity.HasOne(d => d.Status).WithMany(p => p.AttendanceCorrections)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("attendance_correction_ibfk_2");
        });

        modelBuilder.Entity<AttendanceStatus>(entity =>
        {
            entity.HasKey(e => e.StatusId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<AuditLog>(entity =>
        {
            entity.HasKey(e => e.AuditLogId).HasName("PRIMARY");

            entity.Property(e => e.ActionTime).HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.User).WithMany(p => p.AuditLogs).HasConstraintName("audit_log_ibfk_1");
        });

        modelBuilder.Entity<AuthenticationLog>(entity =>
        {
            entity.HasKey(e => e.AuthLogId).HasName("PRIMARY");

            entity.HasOne(d => d.User).WithMany(p => p.AuthenticationLogs).HasConstraintName("authentication_log_ibfk_1");
        });

        modelBuilder.Entity<Backup>(entity =>
        {
            entity.HasKey(e => e.BackupId).HasName("PRIMARY");

            entity.HasOne(d => d.School).WithMany(p => p.Backups).HasConstraintName("backup_ibfk_2");

            entity.HasOne(d => d.Status).WithMany(p => p.Backups)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("backup_ibfk_1");
        });

        modelBuilder.Entity<BackupStatus>(entity =>
        {
            entity.HasKey(e => e.StatusId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<BillingCycle>(entity =>
        {
            entity.HasKey(e => e.CycleId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<Budget>(entity =>
        {
            entity.HasKey(e => e.BudgetId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.RemainingAmount).HasComputedColumnSql("`allocated_amount` - `spent_amount`", true);
            entity.Property(e => e.SpentAmount).HasDefaultValueSql("'0.00'");

            entity.HasOne(d => d.AcademicYear).WithMany(p => p.Budgets)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("budget_ibfk_3");

            entity.HasOne(d => d.School).WithMany(p => p.Budgets)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("budget_ibfk_2");

            entity.HasOne(d => d.Status).WithMany(p => p.Budgets)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("budget_ibfk_1");
        });

        modelBuilder.Entity<BudgetStatus>(entity =>
        {
            entity.HasKey(e => e.StatusId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<Classroom>(entity =>
        {
            entity.HasKey(e => e.ClassroomId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("'0'");
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.AcademicYear).WithMany(p => p.Classrooms)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("classroom_ibfk_2");

            entity.HasOne(d => d.School).WithMany(p => p.Classrooms)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("classroom_ibfk_1");
        });

        modelBuilder.Entity<CorrectionStatus>(entity =>
        {
            entity.HasKey(e => e.StatusId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<DayOfWeeks>(entity =>
        {
            entity.HasKey(e => e.DayId).HasName("PRIMARY");
        });

        modelBuilder.Entity<DeploymentLog>(entity =>
        {
            entity.HasKey(e => e.DeploymentId).HasName("PRIMARY");

            entity.HasOne(d => d.DeployedByNavigation).WithMany(p => p.DeploymentLogs).HasConstraintName("deployment_log_ibfk_2");

            entity.HasOne(d => d.Version).WithMany(p => p.DeploymentLogs).HasConstraintName("deployment_log_ibfk_1");
        });

        modelBuilder.Entity<DimDate>(entity =>
        {
            entity.HasKey(e => e.DateId).HasName("PRIMARY");
        });

        modelBuilder.Entity<DimStudent>(entity =>
        {
            entity.HasKey(e => e.DimStudentId).HasName("PRIMARY");

            entity.HasOne(d => d.Student).WithMany(p => p.DimStudents).HasConstraintName("dim_student_ibfk_1");
        });

        modelBuilder.Entity<DisciplineAction>(entity =>
        {
            entity.HasKey(e => e.ActionId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.ApprovedByNavigation).WithMany(p => p.DisciplineActions).HasConstraintName("discipline_action_ibfk_2");

            entity.HasOne(d => d.Report).WithMany(p => p.DisciplineActions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("discipline_action_ibfk_1");
        });

        modelBuilder.Entity<ErrorLog>(entity =>
        {
            entity.HasKey(e => e.ErrorId).HasName("PRIMARY");

            entity.HasOne(d => d.Severity).WithMany(p => p.ErrorLogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("error_log_ibfk_1");
        });

        modelBuilder.Entity<ErrorSeverity>(entity =>
        {
            entity.HasKey(e => e.SeverityId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<EventCalendar>(entity =>
        {
            entity.HasKey(e => e.EventId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("'0'");
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.School).WithMany(p => p.EventCalendars).HasConstraintName("event_calendar_ibfk_1");
        });

        modelBuilder.Entity<Exam>(entity =>
        {
            entity.HasKey(e => e.ExamId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("'0'");
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.AcademicYear).WithMany(p => p.Exams)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("exam_ibfk_2");

            entity.HasOne(d => d.School).WithMany(p => p.Exams)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("exam_ibfk_1");
        });

        modelBuilder.Entity<FactAttendance>(entity =>
        {
            entity.HasKey(e => e.FactId).HasName("PRIMARY");

            entity.HasOne(d => d.Date).WithMany(p => p.FactAttendances).HasConstraintName("fact_attendance_ibfk_2");

            entity.HasOne(d => d.Student).WithMany(p => p.FactAttendances).HasConstraintName("fact_attendance_ibfk_1");
        });

        modelBuilder.Entity<FactResult>(entity =>
        {
            entity.HasKey(e => e.FactId).HasName("PRIMARY");

            entity.HasOne(d => d.Student).WithMany(p => p.FactResults).HasConstraintName("fact_results_ibfk_1");
        });

        modelBuilder.Entity<FeeExemption>(entity =>
        {
            entity.HasKey(e => e.ExemptionId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.ApprovedByNavigation).WithMany(p => p.FeeExemptions).HasConstraintName("fee_exemption_ibfk_2");

            entity.HasOne(d => d.Student).WithMany(p => p.FeeExemptions).HasConstraintName("fee_exemption_ibfk_1");
        });

        modelBuilder.Entity<FeeStructure>(entity =>
        {
            entity.HasKey(e => e.FeeStructureId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("'0'");
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.AcademicYear).WithMany(p => p.FeeStructures).HasConstraintName("fee_structure_ibfk_2");

            entity.HasOne(d => d.School).WithMany(p => p.FeeStructures).HasConstraintName("fee_structure_ibfk_1");
        });

        modelBuilder.Entity<FeeStructureHistory>(entity =>
        {
            entity.HasKey(e => e.HistoryId).HasName("PRIMARY");

            entity.HasOne(d => d.FeeStructure).WithMany(p => p.FeeStructureHistories).HasConstraintName("fee_structure_history_ibfk_1");
        });

        modelBuilder.Entity<Gender>(entity =>
        {
            entity.HasKey(e => e.GenderId).HasName("PRIMARY");
        });

        modelBuilder.Entity<GoodsReceived>(entity =>
        {
            entity.HasKey(e => e.GrnId).HasName("PRIMARY");

            entity.Property(e => e.ReceivedDate).HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.PurchaseOrder).WithMany(p => p.GoodsReceiveds)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("goods_received_ibfk_1");

            entity.HasOne(d => d.ReceivedByNavigation).WithMany(p => p.GoodsReceiveds)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("goods_received_ibfk_2");
        });

        modelBuilder.Entity<IntegrationStatus>(entity =>
        {
            entity.HasKey(e => e.StatusId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<InventoryItem>(entity =>
        {
            entity.HasKey(e => e.InventoryId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.MinimumStock).HasDefaultValueSql("'0'");
            entity.Property(e => e.Quantity).HasDefaultValueSql("'0'");
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.School).WithMany(p => p.InventoryItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("inventory_item_ibfk_1");
        });

        modelBuilder.Entity<Invoice>(entity =>
        {
            entity.HasKey(e => e.InvoiceId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("'0'");
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.AcademicYear).WithMany(p => p.Invoices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("invoice_ibfk_2");

            entity.HasOne(d => d.Status).WithMany(p => p.Invoices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("invoice_ibfk_3");

            entity.HasOne(d => d.Student).WithMany(p => p.Invoices)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("invoice_ibfk_1");
        });

        modelBuilder.Entity<InvoiceLine>(entity =>
        {
            entity.HasKey(e => e.InvoiceLineId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.Invoice).WithMany(p => p.InvoiceLines).HasConstraintName("invoice_line_ibfk_1");
        });

        modelBuilder.Entity<InvoiceStatus>(entity =>
        {
            entity.HasKey(e => e.StatusId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<LeaveRequest>(entity =>
        {
            entity.HasKey(e => e.LeaveRequestId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.Status).WithMany(p => p.LeaveRequests).HasConstraintName("leave_request_ibfk_2");

            entity.HasOne(d => d.Teacher).WithMany(p => p.LeaveRequests).HasConstraintName("leave_request_ibfk_1");
        });

        modelBuilder.Entity<LessonPlan>(entity =>
        {
            entity.HasKey(e => e.LessonPlanId).HasName("PRIMARY");

            entity.Property(e => e.UploadedAt).HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.AcademicYear).WithMany(p => p.LessonPlans)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("lesson_plan_ibfk_3");

            entity.HasOne(d => d.Subject).WithMany(p => p.LessonPlans)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("lesson_plan_ibfk_2");

            entity.HasOne(d => d.Teacher).WithMany(p => p.LessonPlans)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("lesson_plan_ibfk_1");
        });

        modelBuilder.Entity<Mark>(entity =>
        {
            entity.HasKey(e => e.MarkId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.Exam).WithMany(p => p.Marks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("mark_ibfk_3");

            entity.HasOne(d => d.GradedByTeacher).WithMany(p => p.Marks).HasConstraintName("mark_ibfk_4");

            entity.HasOne(d => d.Student).WithMany(p => p.Marks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("mark_ibfk_1");

            entity.HasOne(d => d.Subject).WithMany(p => p.Marks)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("mark_ibfk_2");
        });

        modelBuilder.Entity<MealPlan>(entity =>
        {
            entity.HasKey(e => e.MealPlanId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("'0'");
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.School).WithMany(p => p.MealPlans).HasConstraintName("meal_plan_ibfk_1");
        });

        modelBuilder.Entity<MealSchedule>(entity =>
        {
            entity.HasKey(e => e.MealScheduleId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.Day).WithMany(p => p.MealSchedules).HasConstraintName("meal_schedule_ibfk_2");

            entity.HasOne(d => d.MealPlan).WithMany(p => p.MealSchedules).HasConstraintName("meal_schedule_ibfk_1");
        });

        modelBuilder.Entity<MisconductReport>(entity =>
        {
            entity.HasKey(e => e.ReportId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.Student).WithMany(p => p.MisconductReports)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("misconduct_report_ibfk_1");

            entity.HasOne(d => d.Teacher).WithMany(p => p.MisconductReports)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("misconduct_report_ibfk_2");
        });

        modelBuilder.Entity<NetworkUptime>(entity =>
        {
            entity.HasKey(e => e.UptimeId).HasName("PRIMARY");

            entity.HasOne(d => d.Status).WithMany(p => p.NetworkUptimes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("network_uptime_ibfk_1");
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.HasKey(e => e.NotificationId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("'0'");
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.Receiver).WithMany(p => p.NotificationReceivers).HasConstraintName("notification_ibfk_2");

            entity.HasOne(d => d.Sender).WithMany(p => p.NotificationSenders).HasConstraintName("notification_ibfk_1");
        });

        modelBuilder.Entity<NotificationLog>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PRIMARY");

            entity.HasOne(d => d.Notification).WithMany(p => p.NotificationLogs).HasConstraintName("notification_log_ibfk_2");

            entity.HasOne(d => d.Status).WithMany(p => p.NotificationLogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("notification_log_ibfk_1");
        });

        modelBuilder.Entity<Parent>(entity =>
        {
            entity.HasKey(e => e.ParentId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("'0'");
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.School).WithMany(p => p.Parents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("parent_ibfk_2");

            entity.HasOne(d => d.User).WithOne(p => p.Parent)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("parent_ibfk_1");
        });

        modelBuilder.Entity<PasswordReset>(entity =>
        {
            entity.HasKey(e => e.ResetId).HasName("PRIMARY");

            entity.HasOne(d => d.User).WithMany(p => p.PasswordResets)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("password_reset_ibfk_1");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.PaymentId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("'0'");
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.AcademicYear).WithMany(p => p.Payments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("payment_ibfk_2");

            entity.HasOne(d => d.Invoice).WithMany(p => p.Payments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("payment_ibfk_1");

            entity.HasOne(d => d.PaymentMethod).WithMany(p => p.Payments).HasConstraintName("payment_ibfk_3");
        });

        modelBuilder.Entity<PaymentMethod>(entity =>
        {
            entity.HasKey(e => e.PaymentMethodId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<PaymentStatus>(entity =>
        {
            entity.HasKey(e => e.StatusId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<Permission>(entity =>
        {
            entity.HasKey(e => e.PermissionId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("'0'");
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()");
        });

        modelBuilder.Entity<ProcurementApprovalLog>(entity =>
        {
            entity.HasKey(e => e.ApprovalLogId).HasName("PRIMARY");

            entity.Property(e => e.ActionDate).HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.ApprovedByNavigation).WithMany(p => p.ProcurementApprovalLogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("procurement_approval_log_ibfk_3");

            entity.HasOne(d => d.Decision).WithMany(p => p.ProcurementApprovalLogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("procurement_approval_log_ibfk_1");

            entity.HasOne(d => d.ProcurementRequest).WithMany(p => p.ProcurementApprovalLogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("procurement_approval_log_ibfk_2");
        });

        modelBuilder.Entity<ProcurementItem>(entity =>
        {
            entity.HasKey(e => e.ProcurementItemId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.TotalPrice).HasComputedColumnSql("`quantity` * `unit_price`", true);
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.InventoryItem).WithMany(p => p.ProcurementItems).HasConstraintName("procurement_item_ibfk_2");

            entity.HasOne(d => d.ProcurementRequest).WithMany(p => p.ProcurementItems)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("procurement_item_ibfk_1");
        });

        modelBuilder.Entity<ProcurementRequest>(entity =>
        {
            entity.HasKey(e => e.ProcurementRequestId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("'0'");
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.ApprovedByNavigation).WithMany(p => p.ProcurementRequestApprovedByNavigations).HasConstraintName("procurement_request_ibfk_4");

            entity.HasOne(d => d.RequestedByNavigation).WithMany(p => p.ProcurementRequestRequestedByNavigations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("procurement_request_ibfk_3");

            entity.HasOne(d => d.School).WithMany(p => p.ProcurementRequests)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("procurement_request_ibfk_1");

            entity.HasOne(d => d.Status).WithMany(p => p.ProcurementRequests)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("procurement_request_ibfk_5");

            entity.HasOne(d => d.Supplier).WithMany(p => p.ProcurementRequests).HasConstraintName("procurement_request_ibfk_2");
        });

        modelBuilder.Entity<PurchaseOrder>(entity =>
        {
            entity.HasKey(e => e.PurchaseOrderId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("'0'");
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.PaymentStatus).WithMany(p => p.PurchaseOrders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("purchase_order_ibfk_2");

            entity.HasOne(d => d.ProcurementRequest).WithMany(p => p.PurchaseOrders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("purchase_order_ibfk_3");

            entity.HasOne(d => d.ReceivedByNavigation).WithMany(p => p.PurchaseOrders).HasConstraintName("purchase_order_ibfk_5");

            entity.HasOne(d => d.Status).WithMany(p => p.PurchaseOrders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("purchase_order_ibfk_1");

            entity.HasOne(d => d.Supplier).WithMany(p => p.PurchaseOrders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("purchase_order_ibfk_4");
        });

        modelBuilder.Entity<PurchaseOrderStatus>(entity =>
        {
            entity.HasKey(e => e.StatusId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<RequestStatus>(entity =>
        {
            entity.HasKey(e => e.StatusId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<ResourceRequest>(entity =>
        {
            entity.HasKey(e => e.ResourceRequestId).HasName("PRIMARY");

            entity.HasOne(d => d.Status).WithMany(p => p.ResourceRequests).HasConstraintName("resource_request_ibfk_2");

            entity.HasOne(d => d.Teacher).WithMany(p => p.ResourceRequests).HasConstraintName("resource_request_ibfk_1");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("'0'");
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()");

            entity.HasMany(d => d.Permissions).WithMany(p => p.Roles)
                .UsingEntity<Dictionary<string, object>>(
                    "RolePermission",
                    r => r.HasOne<Permission>().WithMany()
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("role_permission_ibfk_2"),
                    l => l.HasOne<Role>().WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("role_permission_ibfk_1"),
                    j =>
                    {
                        j.HasKey("RoleId", "PermissionId")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j.ToTable("role_permission");
                        j.HasIndex(new[] { "PermissionId" }, "permission_id");
                        j.IndexerProperty<int>("RoleId")
                            .HasColumnType("int(11)")
                            .HasColumnName("role_id");
                        j.IndexerProperty<int>("PermissionId")
                            .HasColumnType("int(11)")
                            .HasColumnName("permission_id");
                    });
        });

        modelBuilder.Entity<School>(entity =>
        {
            entity.HasKey(e => e.SchoolId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.Status).WithMany(p => p.Schools)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("school_ibfk_1");
        });

        modelBuilder.Entity<SchoolContact>(entity =>
        {
            entity.HasKey(e => e.ContactId).HasName("PRIMARY");

            entity.HasOne(d => d.School).WithMany(p => p.SchoolContacts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("school_contact_ibfk_1");
        });

        modelBuilder.Entity<SchoolStatus>(entity =>
        {
            entity.HasKey(e => e.StatusId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<SecurityIncident>(entity =>
        {
            entity.HasKey(e => e.IncidentId).HasName("PRIMARY");

            entity.HasOne(d => d.User).WithMany(p => p.SecurityIncidents).HasConstraintName("security_incident_ibfk_1");
        });

        modelBuilder.Entity<SoftwareVersion>(entity =>
        {
            entity.HasKey(e => e.VersionId).HasName("PRIMARY");
        });

        modelBuilder.Entity<StatusChangeLog>(entity =>
        {
            entity.HasKey(e => e.StatusChangeId).HasName("PRIMARY");

            entity.Property(e => e.ChangedAt).HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.ChangedByNavigation).WithMany(p => p.StatusChangeLogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("status_change_log_ibfk_1");

            entity.HasOne(d => d.StatusDomain).WithMany(p => p.StatusChangeLogs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("status_change_log_ibfk_2");
        });

        modelBuilder.Entity<StatusDomain>(entity =>
        {
            entity.HasKey(e => e.DomainId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<StatusTransition>(entity =>
        {
            entity.HasKey(e => e.TransitionId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.IsTerminal).HasDefaultValueSql("'0'");
            entity.Property(e => e.RequiresApproval).HasDefaultValueSql("'0'");

            entity.HasOne(d => d.Domain).WithMany(p => p.StatusTransitions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("status_transition_ibfk_1");
        });

        modelBuilder.Entity<StatusTransitionRole>(entity =>
        {
            entity.HasKey(e => e.TransitionRoleId).HasName("PRIMARY");

            entity.HasOne(d => d.Role).WithMany(p => p.StatusTransitionRoles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("status_transition_role_ibfk_2");

            entity.HasOne(d => d.Transition).WithMany(p => p.StatusTransitionRoles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("status_transition_role_ibfk_1");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("'0'");
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.Gender).WithMany(p => p.Students)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("student_ibfk_2");

            entity.HasOne(d => d.School).WithMany(p => p.Students)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("student_ibfk_1");

            entity.HasOne(d => d.Status).WithMany(p => p.Students)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("student_ibfk_3");
        });

        modelBuilder.Entity<StudentBehaviour>(entity =>
        {
            entity.HasKey(e => e.BehaviourId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.RecordedByTeacher).WithMany(p => p.StudentBehaviours)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("student_behaviour_ibfk_2");

            entity.HasOne(d => d.Student).WithMany(p => p.StudentBehaviours)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("student_behaviour_ibfk_1");
        });

        modelBuilder.Entity<StudentEnrollment>(entity =>
        {
            entity.HasKey(e => e.EnrollmentId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.AcademicYear).WithMany(p => p.StudentEnrollments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("student_enrollment_ibfk_3");

            entity.HasOne(d => d.ApprovedByNavigation).WithMany(p => p.StudentEnrollments).HasConstraintName("student_enrollment_ibfk_4");

            entity.HasOne(d => d.Classroom).WithMany(p => p.StudentEnrollments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("student_enrollment_ibfk_2");

            entity.HasOne(d => d.Student).WithMany(p => p.StudentEnrollments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("student_enrollment_ibfk_1");
        });

        modelBuilder.Entity<StudentFeeAccount>(entity =>
        {
            entity.HasKey(e => e.AccountId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.Student).WithMany(p => p.StudentFeeAccounts).HasConstraintName("student_fee_account_ibfk_1");
        });

        modelBuilder.Entity<StudentMeal>(entity =>
        {
            entity.HasKey(e => e.StudentMealId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.AcademicYear).WithMany(p => p.StudentMeals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("student_meal_ibfk_2");

            entity.HasOne(d => d.MealPlan).WithMany(p => p.StudentMeals).HasConstraintName("student_meal_ibfk_3");

            entity.HasOne(d => d.Student).WithMany(p => p.StudentMeals).HasConstraintName("student_meal_ibfk_1");
        });

        modelBuilder.Entity<StudentParent>(entity =>
        {
            entity.HasKey(e => e.StudentParentId).HasName("PRIMARY");

            entity.HasOne(d => d.Parent).WithMany(p => p.StudentParents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("student_parent_ibfk_2");

            entity.HasOne(d => d.Student).WithMany(p => p.StudentParents)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("student_parent_ibfk_1");
        });

        modelBuilder.Entity<StudentStatus>(entity =>
        {
            entity.HasKey(e => e.StatusId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<StudentTransport>(entity =>
        {
            entity.HasKey(e => e.StudentTransportId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.AcademicYear).WithMany(p => p.StudentTransports)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("student_transport_ibfk_2");

            entity.HasOne(d => d.Route).WithMany(p => p.StudentTransports).HasConstraintName("student_transport_ibfk_4");

            entity.HasOne(d => d.Student).WithMany(p => p.StudentTransports).HasConstraintName("student_transport_ibfk_1");

            entity.HasOne(d => d.Transport).WithMany(p => p.StudentTransports).HasConstraintName("student_transport_ibfk_3");
        });

        modelBuilder.Entity<StudyMaterial>(entity =>
        {
            entity.HasKey(e => e.MaterialId).HasName("PRIMARY");

            entity.Property(e => e.UploadedAt).HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.AcademicYear).WithMany(p => p.StudyMaterials)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("study_material_ibfk_3");

            entity.HasOne(d => d.Subject).WithMany(p => p.StudyMaterials)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("study_material_ibfk_2");

            entity.HasOne(d => d.Teacher).WithMany(p => p.StudyMaterials)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("study_material_ibfk_1");
        });

        modelBuilder.Entity<Subject>(entity =>
        {
            entity.HasKey(e => e.SubjectId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("'0'");
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.School).WithMany(p => p.Subjects)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("subject_ibfk_1");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.SupplierId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.School).WithMany(p => p.Suppliers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("supplier_ibfk_3");

            entity.HasOne(d => d.Status).WithMany(p => p.Suppliers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("supplier_ibfk_1");

            entity.HasOne(d => d.SupplierType).WithMany(p => p.Suppliers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("supplier_ibfk_2");
        });

        modelBuilder.Entity<SupplierStatus>(entity =>
        {
            entity.HasKey(e => e.StatusId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<SupplierType>(entity =>
        {
            entity.HasKey(e => e.SupplierTypeId).HasName("PRIMARY");
        });

        modelBuilder.Entity<SupportTicket>(entity =>
        {
            entity.HasKey(e => e.TicketId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("'0'");
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.Status).WithMany(p => p.SupportTickets)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("support_ticket_ibfk_1");

            entity.HasOne(d => d.User).WithMany(p => p.SupportTickets).HasConstraintName("support_ticket_ibfk_2");
        });

        modelBuilder.Entity<SystemResourceMetric>(entity =>
        {
            entity.HasKey(e => e.MetricId).HasName("PRIMARY");
        });

        modelBuilder.Entity<SystemUsageMetric>(entity =>
        {
            entity.HasKey(e => e.MetricId).HasName("PRIMARY");
        });

        modelBuilder.Entity<Teacher>(entity =>
        {
            entity.HasKey(e => e.TeacherId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("'0'");
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.School).WithMany(p => p.Teachers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("teacher_ibfk_2");

            entity.HasOne(d => d.User).WithOne(p => p.Teacher)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("teacher_ibfk_1");
        });

        modelBuilder.Entity<TeacherAssignment>(entity =>
        {
            entity.HasKey(e => e.TeacherAssignmentId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.AcademicYear).WithMany(p => p.TeacherAssignments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("teacher_assignment_ibfk_4");

            entity.HasOne(d => d.Classroom).WithMany(p => p.TeacherAssignments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("teacher_assignment_ibfk_2");

            entity.HasOne(d => d.Subject).WithMany(p => p.TeacherAssignments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("teacher_assignment_ibfk_3");

            entity.HasOne(d => d.Teacher).WithMany(p => p.TeacherAssignments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("teacher_assignment_ibfk_1");
        });

        modelBuilder.Entity<TeacherPerformance>(entity =>
        {
            entity.HasKey(e => e.PerformanceId).HasName("PRIMARY");

            entity.HasOne(d => d.AcademicYear).WithMany(p => p.TeacherPerformances).HasConstraintName("teacher_performance_ibfk_2");

            entity.HasOne(d => d.Teacher).WithMany(p => p.TeacherPerformances).HasConstraintName("teacher_performance_ibfk_1");
        });

        modelBuilder.Entity<TenantSetting>(entity =>
        {
            entity.HasKey(e => e.SettingId).HasName("PRIMARY");

            entity.HasOne(d => d.School).WithMany(p => p.TenantSettings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tenant_setting_ibfk_1");
        });

        modelBuilder.Entity<TenantSubscription>(entity =>
        {
            entity.HasKey(e => e.SubscriptionId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");

            entity.HasOne(d => d.School).WithOne(p => p.TenantSubscription)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tenant_subscription_ibfk_1");
        });

        modelBuilder.Entity<TicketStatus>(entity =>
        {
            entity.HasKey(e => e.StatusId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<TimetableSlot>(entity =>
        {
            entity.HasKey(e => e.TimetableSlotId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.Classroom).WithMany(p => p.TimetableSlots)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("timetable_slot_ibfk_1");

            entity.HasOne(d => d.Day).WithMany(p => p.TimetableSlots)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("timetable_slot_ibfk_4");

            entity.HasOne(d => d.Subject).WithMany(p => p.TimetableSlots)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("timetable_slot_ibfk_2");

            entity.HasOne(d => d.Teacher).WithMany(p => p.TimetableSlots)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("timetable_slot_ibfk_3");
        });

        modelBuilder.Entity<Transport>(entity =>
        {
            entity.HasKey(e => e.TransportId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("'0'");
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.School).WithMany(p => p.Transports).HasConstraintName("transport_ibfk_1");
        });

        modelBuilder.Entity<TransportFee>(entity =>
        {
            entity.HasKey(e => e.TransportFeeId).HasName("PRIMARY");

            entity.HasOne(d => d.Cycle).WithMany(p => p.TransportFees).HasConstraintName("transport_fee_ibfk_3");

            entity.HasOne(d => d.Route).WithMany(p => p.TransportFees).HasConstraintName("transport_fee_ibfk_2");

            entity.HasOne(d => d.School).WithMany(p => p.TransportFees).HasConstraintName("transport_fee_ibfk_1");
        });

        modelBuilder.Entity<TransportRoute>(entity =>
        {
            entity.HasKey(e => e.RouteId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.IsDeleted).HasDefaultValueSql("'0'");
            entity.Property(e => e.UpdatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp()");

            entity.HasOne(d => d.School).WithMany(p => p.TransportRoutes).HasConstraintName("transport_route_ibfk_1");
        });

        modelBuilder.Entity<UptimeStatus>(entity =>
        {
            entity.HasKey(e => e.StatusId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<UserRole>(entity =>
        {
            entity.HasKey(e => e.UserRoleId).HasName("PRIMARY");

            entity.HasOne(d => d.Role).WithMany(p => p.UserRoles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("user_role_ibfk_2");

            entity.HasOne(d => d.User).WithMany(p => p.UserRoles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("user_role_ibfk_1");
        });

        modelBuilder.Entity<UserSession>(entity =>
        {
            entity.HasKey(e => e.SessionId).HasName("PRIMARY");

            entity.HasOne(d => d.User).WithMany(p => p.UserSessions)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("user_session_ibfk_1");
        });

        modelBuilder.Entity<UserStatus>(entity =>
        {
            entity.HasKey(e => e.StatusId).HasName("PRIMARY");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("current_timestamp()");
            entity.Property(e => e.IsActive).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<VwProcurementRequestsReceived>(entity =>
        {
            entity.ToView("vw_procurement_requests_received");

            entity.Property(e => e.SubmittedAt).HasDefaultValueSql("current_timestamp()");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
