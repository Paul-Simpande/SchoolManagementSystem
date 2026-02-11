using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("meal_plan")]
[Index("SchoolId", Name = "idx_meal_plan_school")]
public partial class MealPlan
{
    [Key]
    [Column("meal_plan_id", TypeName = "int(11)")]
    public int MealPlanId { get; set; }

    [Column("school_id", TypeName = "int(11)")]
    public int? SchoolId { get; set; }

    [Column("plan_name")]
    [StringLength(100)]
    public string? PlanName { get; set; }

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    [Column("is_deleted")]
    public bool? IsDeleted { get; set; }

    [Column("deleted_at", TypeName = "datetime")]
    public DateTime? DeletedAt { get; set; }

    [InverseProperty("MealPlan")]
    public virtual ICollection<MealSchedule> MealSchedules { get; set; } = new List<MealSchedule>();

    [ForeignKey("SchoolId")]
    [InverseProperty("MealPlans")]
    public virtual School? School { get; set; }

    [InverseProperty("MealPlan")]
    public virtual ICollection<StudentMeal> StudentMeals { get; set; } = new List<StudentMeal>();
}
