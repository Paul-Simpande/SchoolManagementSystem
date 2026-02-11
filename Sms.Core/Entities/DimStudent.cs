using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("dim_student")]
[Index("StudentId", Name = "student_id")]
public partial class DimStudent
{
    [Key]
    [Column("dim_student_id", TypeName = "int(11)")]
    public int DimStudentId { get; set; }

    [Column("student_id", TypeName = "int(11)")]
    public int? StudentId { get; set; }

    [ForeignKey("StudentId")]
    [InverseProperty("DimStudents")]
    public virtual Student? Student { get; set; }
}
