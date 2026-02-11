using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("meal_schedule")]
[Index("DayId", Name = "day_id")]
[Index("MealPlanId", Name = "meal_plan_id")]
public partial class MealSchedule
{
    [Key]
    [Column("meal_schedule_id", TypeName = "int(11)")]
    public int MealScheduleId { get; set; }

    [Column("meal_plan_id", TypeName = "int(11)")]
    public int? MealPlanId { get; set; }

    [Column("day_id", TypeName = "int(11)")]
    public int? DayId { get; set; }

    [Column("meal_description")]
    [StringLength(255)]
    public string? MealDescription { get; set; }

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    [ForeignKey("DayId")]
    [InverseProperty("MealSchedules")]
    public virtual DayOfWeeks? Day { get; set; }

    [ForeignKey("MealPlanId")]
    [InverseProperty("MealSchedules")]
    public virtual MealPlan? MealPlan { get; set; }
}
