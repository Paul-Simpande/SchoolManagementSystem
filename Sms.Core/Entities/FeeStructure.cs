using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("fee_structure")]
[Index("SchoolId", Name = "idx_fee_structure_school")]
[Index("AcademicYearId", Name = "idx_fee_structure_year")]
public partial class FeeStructure
{
    [Key]
    [Column("fee_structure_id", TypeName = "int(11)")]
    public int FeeStructureId { get; set; }

    [Column("school_id", TypeName = "int(11)")]
    public int? SchoolId { get; set; }

    [Column("academic_year_id", TypeName = "int(11)")]
    public int? AcademicYearId { get; set; }

    [Column("fee_type")]
    [StringLength(100)]
    public string? FeeType { get; set; }

    [Column("amount")]
    [Precision(10, 2)]
    public decimal? Amount { get; set; }

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    [Column("is_deleted")]
    public bool? IsDeleted { get; set; }

    [Column("deleted_at", TypeName = "datetime")]
    public DateTime? DeletedAt { get; set; }

    [ForeignKey("AcademicYearId")]
    [InverseProperty("FeeStructures")]
    public virtual AcademicYear? AcademicYear { get; set; }

    [InverseProperty("FeeStructure")]
    public virtual ICollection<FeeStructureHistory> FeeStructureHistories { get; set; } = new List<FeeStructureHistory>();

    [ForeignKey("SchoolId")]
    [InverseProperty("FeeStructures")]
    public virtual School? School { get; set; }
}
