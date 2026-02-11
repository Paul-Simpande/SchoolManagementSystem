using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("day_of_week")]
[Index("DayName", Name = "day_name", IsUnique = true)]
public partial class DayOfWeeks
{
    [Key]
    [Column("day_id", TypeName = "int(11)")]
    public int DayId { get; set; }

    [Column("day_name")]
    [StringLength(20)]
    public string DayName { get; set; } = null!;

    [InverseProperty("Day")]
    public virtual ICollection<MealSchedule> MealSchedules { get; set; } = new List<MealSchedule>();

    [InverseProperty("Day")]
    public virtual ICollection<TimetableSlot> TimetableSlots { get; set; } = new List<TimetableSlot>();
}
