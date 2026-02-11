using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("student_meal")]
[Index("AcademicYearId", Name = "academic_year_id")]
[Index("StudentId", Name = "idx_student_meal_student")]
[Index("MealPlanId", Name = "meal_plan_id")]
public partial class StudentMeal
{
    [Key]
    [Column("student_meal_id", TypeName = "int(11)")]
    public int StudentMealId { get; set; }

    [Column("student_id", TypeName = "int(11)")]
    public int? StudentId { get; set; }

    [Column("meal_plan_id", TypeName = "int(11)")]
    public int? MealPlanId { get; set; }

    [Column("academic_year_id", TypeName = "int(11)")]
    public int AcademicYearId { get; set; }

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    [ForeignKey("AcademicYearId")]
    [InverseProperty("StudentMeals")]
    public virtual AcademicYear AcademicYear { get; set; } = null!;

    [ForeignKey("MealPlanId")]
    [InverseProperty("StudentMeals")]
    public virtual MealPlan? MealPlan { get; set; }

    [ForeignKey("StudentId")]
    [InverseProperty("StudentMeals")]
    public virtual Student? Student { get; set; }
}
