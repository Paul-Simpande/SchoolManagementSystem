using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("subject")]
[Index("SchoolId", Name = "idx_subject_school")]
[Index("SchoolId", "SubjectName", Name = "school_id", IsUnique = true)]
public partial class Subject
{
    [Key]
    [Column("subject_id", TypeName = "int(11)")]
    public int SubjectId { get; set; }

    [Column("school_id", TypeName = "int(11)")]
    public int SchoolId { get; set; }

    [Column("subject_name")]
    [StringLength(100)]
    public string SubjectName { get; set; } = null!;

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    [Column("is_deleted")]
    public bool? IsDeleted { get; set; }

    [Column("deleted_at", TypeName = "datetime")]
    public DateTime? DeletedAt { get; set; }

    [InverseProperty("Subject")]
    public virtual ICollection<Assignment> Assignments { get; set; } = new List<Assignment>();

    [InverseProperty("Subject")]
    public virtual ICollection<LessonPlan> LessonPlans { get; set; } = new List<LessonPlan>();

    [InverseProperty("Subject")]
    public virtual ICollection<Mark> Marks { get; set; } = new List<Mark>();

    [ForeignKey("SchoolId")]
    [InverseProperty("Subjects")]
    public virtual School School { get; set; } = null!;

    [InverseProperty("Subject")]
    public virtual ICollection<StudyMaterial> StudyMaterials { get; set; } = new List<StudyMaterial>();

    [InverseProperty("Subject")]
    public virtual ICollection<TeacherAssignment> TeacherAssignments { get; set; } = new List<TeacherAssignment>();

    [InverseProperty("Subject")]
    public virtual ICollection<TimetableSlot> TimetableSlots { get; set; } = new List<TimetableSlot>();
}
