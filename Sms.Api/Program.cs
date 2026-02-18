using Microsoft.EntityFrameworkCore;
using Sms.Api.GraphQL.Mutations.CoreTenant;
using Sms.Api.GraphQL.Queries;
using Sms.Api.GraphQL.Queries.CoreTenant;
using Sms.Api.GraphQL.Queries.NonStatusMaster;
using Sms.Api.GraphQL.Queries.StatusBased;
using Sms.Core.Interfaces;
using Sms.Core.Interfaces.CoreTenant;
using Sms.Core.Interfaces.NonStatusMaster;
using Sms.Core.Interfaces.StatusBased;
using Sms.Infrastructure.Context;
using Sms.Infrastructure.Repositories;
using Sms.Infrastructure.Repositories.CoreTenant;
using Sms.Infrastructure.Repositories.NonStatusMaster;
using Sms.Infrastructure.Repositories.StatusBased;
using Sms.Services;
using Sms.Services.CoreTenant;
using Sms.Services.NonStatusMaster;
using Sms.Services.StatusBased;
using static Microsoft.AspNetCore.Builder.WebApplication;
using SchoolQuery = Sms.Api.GraphQL.Queries.CoreTenant.SchoolQuery;

var builder = CreateBuilder(args);

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


#endregion


#region REST + WEBHOOKS

builder.Services.AddControllers();

#endregion

#region GRAPHQL (Queries + Mutations)

builder.Services
    .AddGraphQLServer()
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
    .AddMutationType(d => d.Name("Mutation"))
    .AddType<SchoolMutation>()
    .AddType<AcademicYearMutation>()
    .AddType<AcademicTermMutation>()
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

app.UseAuthorization();

app.MapControllers();    // REST + Webhooks
app.MapGraphQL("/graphql");

#endregion

app.Run();