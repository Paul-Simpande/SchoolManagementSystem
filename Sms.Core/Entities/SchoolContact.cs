using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("school_contact")]
[Index("SchoolId", Name = "school_id")]
public partial class SchoolContact
{
    [Key]
    [Column("contact_id", TypeName = "int(11)")]
    public int ContactId { get; set; }

    [Column("school_id", TypeName = "int(11)")]
    public int SchoolId { get; set; }

    [Column("contact_type")]
    [StringLength(50)]
    public string? ContactType { get; set; }

    [Column("contact_value")]
    [StringLength(150)]
    public string? ContactValue { get; set; }

    [ForeignKey("SchoolId")]
    [InverseProperty("SchoolContacts")]
    public virtual School School { get; set; } = null!;
}
