using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("gender")]
[Index("GenderName", Name = "gender_name", IsUnique = true)]
public partial class Gender
{
    [Key]
    [Column("gender_id", TypeName = "int(11)")]
    public int GenderId { get; set; }

    [Column("gender_name")]
    [StringLength(20)]
    public string GenderName { get; set; } = null!;

    [InverseProperty("Gender")]
    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
