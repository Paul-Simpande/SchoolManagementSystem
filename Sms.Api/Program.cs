using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Sms.Services.Security;
using Sms.Api.GraphQL.Mutations.Auth;
using Sms.Api.GraphQL.Mutations.CoreTenant;
using Sms.Api.GraphQL.Mutations.Engine;
using Sms.Api.GraphQL.Mutations.PupilAdmissionManagement;
using Sms.Api.GraphQL.Mutations.UserAccountManagement;
using Sms.Api.GraphQL.Queries;
using Sms.Api.GraphQL.Queries.CoreTenant;
using Sms.Api.GraphQL.Queries.Engine;
using Sms.Api.GraphQL.Queries.NonStatusMaster;
using Sms.Api.GraphQL.Queries.PupilAdmissionManagement;
using Sms.Api.GraphQL.Queries.StatusBased;
using Sms.Api.GraphQL.Queries.UserAccountManagement;
using Sms.Core.Interfaces;
using Sms.Core.Interfaces.CoreTenant;
using Sms.Core.Interfaces.Engine;
using Sms.Core.Interfaces.NonStatusMaster;
using Sms.Core.Interfaces.PupilsAdmissionManagement;
using Sms.Core.Interfaces.StatusBased;
using Sms.Core.Interfaces.UserAccountManagement;
using Sms.Infrastructure.Context;
using Sms.Infrastructure.Repositories;
using Sms.Infrastructure.Repositories.CoreTenant;
using Sms.Infrastructure.Repositories.Engine;
using Sms.Infrastructure.Repositories.NonStatusMaster;
using Sms.Infrastructure.Repositories.PupilsAdmissionManagement;
using Sms.Infrastructure.Repositories.StatusBased;
using Sms.Infrastructure.Repositories.UserAccountManagement;
using Sms.Services;
using Sms.Services.CoreTenant;
using Sms.Services.Engine;
using Sms.Services.NonStatusMaster;
using Sms.Services.PupilAdmissionManagement;
using Sms.Services.StatusBased;
using Sms.Services.UserAccountManagement;
using static Microsoft.AspNetCore.Builder.WebApplication;
using SchoolQuery = Sms.Api.GraphQL.Queries.CoreTenant.SchoolQuery;

var builder = CreateBuilder(args);

#region CORS

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend", policy =>
    {
        policy
            .WithOrigins("http://localhost:5173")
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowCredentials();
    });
});

#endregion

#region DATABASE (MySQL)

builder.Services.AddDbContext<SchoolDbContext>(options =>
{
    options.UseMySql(
        builder.Configuration.GetConnectionString("DefaultConnection"),
        ServerVersion.AutoDetect(
            builder.Configuration.GetConnectionString("DefaultConnection")
        )
    );
});

#endregion

#region DEPENDENCY INJECTION (CORE)

// Register repository first
builder.Services.AddScoped<ISchoolRepository, SchoolRepository>();
builder.Services.AddScoped<IAcademicYearRepository, AcademicYearRepository>();
builder.Services.AddScoped<IAuditLogRepository, AuditLogRepository>();
builder.Services.AddScoped<IAcademicTermRepository, AcademicTermRepository>();
builder.Services.AddScoped<ISchoolStatusRepository, SchoolStatusRepository>();
builder.Services.AddScoped<IUserStatusRepository, UserStatusRepository>();
builder.Services.AddScoped<IStudentStatusRepository, StudentStatusRepository>();
builder.Services.AddScoped<IGenderRepository, GenderRepository>();
builder.Services.AddScoped<IDayOfWeekRepository, DayOfWeekRepository>();
builder.Services.AddScoped<IAttendanceStatusRepository, AttendanceStatusRepository>();
builder.Services.AddScoped<IInvoiceStatusRepository, InvoiceStatusRepository>();
builder.Services.AddScoped<IPaymentMethodRepository, PaymentMethodRepository>();
builder.Services.AddScoped<IBillingCycleRepository, BillingCycleRepository>();
builder.Services.AddScoped<IRequestStatusRepository, RequestStatusRepository>();
builder.Services.AddScoped<ISupplierStatusRepository, SupplierStatusRepository>();
builder.Services.AddScoped<IBudgetStatusRepository, BudgetStatusRepository>();
builder.Services.AddScoped<IPurchaseOrderStatusRepository, PurchaseOrderStatusRepository>();
builder.Services.AddScoped<IPaymentStatusRepository, PaymentStatusRepository>();
builder.Services.AddScoped<IAdmissionStatusRepository, AdmissionStatusRepository>();
builder.Services.AddScoped<ICorrectionStatusRepository, CorrectionStatusRepository>();
builder.Services.AddScoped<ITicketStatusRepository, TicketStatusRepository>();
builder.Services.AddScoped<IIntegrationStatusRepository, IntegrationStatusRepository>();
builder.Services.AddScoped<IUptimeStatusRepository, UptimeStatusRepository>();
builder.Services.AddScoped<ISupplierTypeRepository, SupplierTypeRepository>();
builder.Services.AddScoped<IAppUserRepository, AppUserRepository>();
builder.Services.AddScoped<IRoleRepository, RoleRepository>();
builder.Services.AddScoped<IUserRoleRepository, UserRoleRepository>();
builder.Services.AddScoped<IPupilRepository, PupilRepository>();
builder.Services.AddScoped<IClassroomRepository, ClassroomRepository>();
builder.Services.AddScoped<IPupilsEnrollmentRepository, PupilsEnrollmentRepository>();

builder.Services.AddAuthentication("Bearer")
    .AddJwtBearer("Bearer", options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,

            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidAudience = builder.Configuration["Jwt:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]!))
        };
    });

builder.Services.AddAuthorization();

// Then register service
builder.Services.AddScoped<SchoolService>();
builder.Services.AddScoped<AcademicYearService>();
builder.Services.AddScoped<AuditLogService>();
builder.Services.AddScoped<AcademicTermService>();
builder.Services.AddScoped<SchoolStatusService>();
builder.Services.AddScoped<UserStatusService>();
builder.Services.AddScoped<StudentStatusService>();
builder.Services.AddScoped<GenderService>();
builder.Services.AddScoped<DayOfWeeksService>();
builder.Services.AddScoped<AttendanceStatusService>();
builder.Services.AddScoped<InvoiceStatusService>();
builder.Services.AddScoped<PaymentMethodService>();
builder.Services.AddScoped<BillingCycleService>();
builder.Services.AddScoped<SchoolStatusService>();
builder.Services.AddScoped<UserStatusService>();
builder.Services.AddScoped<RequestStatusService>();
builder.Services.AddScoped<SupplierStatusService>();
builder.Services.AddScoped<BudgetStatusService>();
builder.Services.AddScoped<PurchaseOrderStatusService>();
builder.Services.AddScoped<PaymentStatusService>();
builder.Services.AddScoped<AdmissionStatusService>();
builder.Services.AddScoped<CorrectionStatusService>();
builder.Services.AddScoped<TicketStatusService>();
builder.Services.AddScoped<IntegrationStatusService>();
builder.Services.AddScoped<UptimeStatusService>();
builder.Services.AddScoped<SupplierTypeService>();
builder.Services.AddScoped<AppUserService>();
builder.Services.AddScoped<RoleService>();
builder.Services.AddScoped<UserRoleService>();
builder.Services.AddScoped<JwtTokenService>();
builder.Services.AddScoped<PupilService>();
builder.Services.AddScoped<ClassroomService>();
builder.Services.AddScoped<PupilsEnrollmentService>();

#endregion


#region REST + WEBHOOKS

builder.Services.AddControllers();

#endregion

#region GRAPHQL (Queries + Mutations)

builder.Services
    .AddGraphQLServer()
    .AddAuthorization()
    .AddType(new DateType())
    .ModifyRequestOptions(opt =>
    {
        opt.IncludeExceptionDetails = true;
    })
    .AddQueryType(d => d.Name("Query"))
    .AddType<AuditLogQuery>()
    .AddType<SchoolQuery>()
    .AddType<AcademicYearQuery>()
    .AddType<SchoolStatusQuery>()
    .AddType<AcademicTermQuery>()
    .AddType<UserStatusQuery>()
    .AddType<StudentStatusQuery>()
    .AddType<GenderQuery>() 
    .AddType<DayOfWeekQuery>()
    .AddType<AttendanceStatusQuery>()
    .AddType<InvoiceStatusQuery>()
    .AddType<PaymentMethodQuery>()
    .AddType<BillingCycleQuery>()
    .AddType<RequestStatusQuery>()
    .AddType<SupplierStatusQuery>()
    .AddType<BudgetStatusQuery>()
    .AddType<PurchaseOrderStatusQuery>()
    .AddType<PaymentStatusQuery>()
    .AddType<AdmissionStatusQuery>()
    .AddType<CorrectionStatusQuery>()
    .AddType<TicketStatusQuery>()
    .AddType<IntegrationStatusQuery>()
    .AddType<UptimeStatusQuery>()
    .AddType<SupplierTypeQuery>()
    .AddType<AppUserQuery>()
    .AddType<RoleQueries>()
    .AddType<UserRoleQuery>()
    .AddType<PupilQuery>()
    .AddType<ClassroomQuery>()
    .AddType<PupilsEnrollmentQuery>()
    .AddMutationType(d => d.Name("Mutation"))
    .AddType<SchoolMutation>()
    .AddType<AcademicYearMutation>()
    .AddType<AcademicTermMutation>()
    .AddType<AppUserMutation>()
    .AddType<UserRoleMutation>()
    .AddType<AuthMutation>()
    .AddType<PupilsMutation>()
    .AddType<ClassroomMutation>()
    .AddType<PupilsEnrollmentMutation>()
    .AddType<DateType>();


#endregion

#region SWAGGER (Optional but Recommended)

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#endregion

var app = builder.Build();

#region PIPELINE

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();

app.UseCors("AllowFrontend");

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();    // REST + Webhooks
app.MapGraphQL("/graphql");

#endregion

app.Run();
