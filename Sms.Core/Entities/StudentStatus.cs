using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("student_status")]
[Index("StatusName", Name = "status_name", IsUnique = true)]
public partial class StudentStatus
{
    [Key]
    [Column("status_id", TypeName = "int(11)")]
    public int StatusId { get; set; }

    [Column("status_name")]
    [StringLength(50)]
    public string StatusName { get; set; } = null!;

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("is_active")]
    public bool? IsActive { get; set; }

    [InverseProperty("Status")]
    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
