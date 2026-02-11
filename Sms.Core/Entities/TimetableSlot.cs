using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("timetable_slot")]
[Index("ClassroomId", Name = "idx_timetable_classroom")]
[Index("DayId", Name = "idx_timetable_day")]
[Index("TeacherId", Name = "idx_timetable_teacher")]
[Index("SubjectId", Name = "subject_id")]
public partial class TimetableSlot
{
    [Key]
    [Column("timetable_slot_id", TypeName = "int(11)")]
    public int TimetableSlotId { get; set; }

    [Column("classroom_id", TypeName = "int(11)")]
    public int ClassroomId { get; set; }

    [Column("subject_id", TypeName = "int(11)")]
    public int SubjectId { get; set; }

    [Column("teacher_id", TypeName = "int(11)")]
    public int TeacherId { get; set; }

    [Column("day_id", TypeName = "int(11)")]
    public int DayId { get; set; }

    [Column("start_time", TypeName = "time")]
    public TimeOnly StartTime { get; set; }

    [Column("end_time", TypeName = "time")]
    public TimeOnly EndTime { get; set; }

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    [InverseProperty("TimetableSlot")]
    public virtual ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();

    [ForeignKey("ClassroomId")]
    [InverseProperty("TimetableSlots")]
    public virtual Classroom Classroom { get; set; } = null!;

    [ForeignKey("DayId")]
    [InverseProperty("TimetableSlots")]
    public virtual DayOfWeeks Day { get; set; } = null!;

    [ForeignKey("SubjectId")]
    [InverseProperty("TimetableSlots")]
    public virtual Subject Subject { get; set; } = null!;

    [ForeignKey("TeacherId")]
    [InverseProperty("TimetableSlots")]
    public virtual Teacher Teacher { get; set; } = null!;
}
