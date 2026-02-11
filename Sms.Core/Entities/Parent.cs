using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("parent")]
[Index("SchoolId", Name = "idx_parent_school")]
[Index("UserId", Name = "user_id", IsUnique = true)]
public partial class Parent
{
    [Key]
    [Column("parent_id", TypeName = "int(11)")]
    public int ParentId { get; set; }

    [Column("user_id", TypeName = "int(11)")]
    public int UserId { get; set; }

    [Column("school_id", TypeName = "int(11)")]
    public int SchoolId { get; set; }

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    [Column("is_deleted")]
    public bool? IsDeleted { get; set; }

    [Column("deleted_at", TypeName = "datetime")]
    public DateTime? DeletedAt { get; set; }

    [ForeignKey("SchoolId")]
    [InverseProperty("Parents")]
    public virtual School School { get; set; } = null!;

    [InverseProperty("Parent")]
    public virtual ICollection<StudentParent> StudentParents { get; set; } = new List<StudentParent>();

    [ForeignKey("UserId")]
    [InverseProperty("Parent")]
    public virtual AppUser User { get; set; } = null!;
}
