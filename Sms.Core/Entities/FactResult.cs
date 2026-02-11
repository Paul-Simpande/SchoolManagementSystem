using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("fact_results")]
[Index("StudentId", Name = "idx_fact_results_student")]
public partial class FactResult
{
    [Key]
    [Column("fact_id", TypeName = "int(11)")]
    public int FactId { get; set; }

    [Column("student_id", TypeName = "int(11)")]
    public int? StudentId { get; set; }

    [Column("average_score")]
    [Precision(5, 2)]
    public decimal? AverageScore { get; set; }

    [ForeignKey("StudentId")]
    [InverseProperty("FactResults")]
    public virtual Student? Student { get; set; }
}
