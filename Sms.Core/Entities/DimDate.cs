using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("dim_date")]
public partial class DimDate
{
    [Key]
    [Column("date_id", TypeName = "int(11)")]
    public int DateId { get; set; }

    [Column("full_date")]
    public DateOnly? FullDate { get; set; }

    [InverseProperty("Date")]
    public virtual ICollection<FactAttendance> FactAttendances { get; set; } = new List<FactAttendance>();
}
