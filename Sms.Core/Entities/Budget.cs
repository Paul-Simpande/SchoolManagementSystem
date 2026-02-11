using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("budget")]
[Index("SchoolId", Name = "idx_budget_school")]
[Index("StatusId", Name = "idx_budget_status")]
[Index("AcademicYearId", Name = "idx_budget_year")]
public partial class Budget
{
    [Key]
    [Column("budget_id", TypeName = "int(11)")]
    public int BudgetId { get; set; }

    [Column("school_id", TypeName = "int(11)")]
    public int SchoolId { get; set; }

    [Column("academic_year_id", TypeName = "int(11)")]
    public int AcademicYearId { get; set; }

    [Column("budget_name")]
    [StringLength(150)]
    public string BudgetName { get; set; } = null!;

    [Column("allocated_amount")]
    [Precision(12, 2)]
    public decimal AllocatedAmount { get; set; }

    [Column("spent_amount")]
    [Precision(12, 2)]
    public decimal? SpentAmount { get; set; }

    [Column("remaining_amount")]
    [Precision(12, 2)]
    public decimal? RemainingAmount { get; set; }

    [Column("status_id", TypeName = "int(11)")]
    public int StatusId { get; set; }

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [ForeignKey("AcademicYearId")]
    [InverseProperty("Budgets")]
    public virtual AcademicYear AcademicYear { get; set; } = null!;

    [ForeignKey("SchoolId")]
    [InverseProperty("Budgets")]
    public virtual School School { get; set; } = null!;

    [ForeignKey("StatusId")]
    [InverseProperty("Budgets")]
    public virtual BudgetStatus Status { get; set; } = null!;
}
