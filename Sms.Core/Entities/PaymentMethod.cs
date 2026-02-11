using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("payment_method")]
[Index("MethodName", Name = "method_name", IsUnique = true)]
public partial class PaymentMethod
{
    [Key]
    [Column("payment_method_id", TypeName = "int(11)")]
    public int PaymentMethodId { get; set; }

    [Column("method_name")]
    [StringLength(50)]
    public string MethodName { get; set; } = null!;

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("is_active")]
    public bool? IsActive { get; set; }

    [InverseProperty("PaymentMethod")]
    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
}
