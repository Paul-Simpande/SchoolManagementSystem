using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("student_behaviour")]
[Index("RecordedByTeacherId", Name = "recorded_by_teacher_id")]
[Index("StudentId", Name = "student_id")]
public partial class StudentBehaviour
{
    [Key]
    [Column("behaviour_id", TypeName = "int(11)")]
    public int BehaviourId { get; set; }

    [Column("student_id", TypeName = "int(11)")]
    public int StudentId { get; set; }

    [Column("recorded_by_teacher_id", TypeName = "int(11)")]
    public int RecordedByTeacherId { get; set; }

    [Column("behaviour_note", TypeName = "text")]
    public string? BehaviourNote { get; set; }

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    [ForeignKey("RecordedByTeacherId")]
    [InverseProperty("StudentBehaviours")]
    public virtual Teacher RecordedByTeacher { get; set; } = null!;

    [ForeignKey("StudentId")]
    [InverseProperty("StudentBehaviours")]
    public virtual Student Student { get; set; } = null!;
}
