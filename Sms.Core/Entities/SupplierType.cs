using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("supplier_type")]
[Index("TypeName", Name = "type_name", IsUnique = true)]
public partial class SupplierType
{
    [Key]
    [Column("supplier_type_id", TypeName = "int(11)")]
    public int SupplierTypeId { get; set; }

    [Column("type_name")]
    [StringLength(100)]
    public string TypeName { get; set; } = null!;

    [InverseProperty("SupplierType")]
    public virtual ICollection<Supplier> Suppliers { get; set; } = new List<Supplier>();
}
