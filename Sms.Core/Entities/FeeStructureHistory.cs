using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("fee_structure_history")]
[Index("FeeStructureId", Name = "fee_structure_id")]
public partial class FeeStructureHistory
{
    [Key]
    [Column("history_id", TypeName = "int(11)")]
    public int HistoryId { get; set; }

    [Column("fee_structure_id", TypeName = "int(11)")]
    public int? FeeStructureId { get; set; }

    [Column("effective_from", TypeName = "datetime")]
    public DateTime? EffectiveFrom { get; set; }

    [ForeignKey("FeeStructureId")]
    [InverseProperty("FeeStructureHistories")]
    public virtual FeeStructure? FeeStructure { get; set; }
}
