using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("student_parent")]
[Index("ParentId", Name = "idx_student_parent_parent")]
[Index("StudentId", Name = "idx_student_parent_student")]
[Index("StudentId", "ParentId", Name = "student_id", IsUnique = true)]
public partial class StudentParent
{
    [Key]
    [Column("student_parent_id", TypeName = "int(11)")]
    public int StudentParentId { get; set; }

    [Column("student_id", TypeName = "int(11)")]
    public int StudentId { get; set; }

    [Column("parent_id", TypeName = "int(11)")]
    public int ParentId { get; set; }

    [Column("relationship")]
    [StringLength(50)]
    public string? Relationship { get; set; }

    [ForeignKey("ParentId")]
    [InverseProperty("StudentParents")]
    public virtual Parent Parent { get; set; } = null!;

    [ForeignKey("StudentId")]
    [InverseProperty("StudentParents")]
    public virtual Student Student { get; set; } = null!;
}
