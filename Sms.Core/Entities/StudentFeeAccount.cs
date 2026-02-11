using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("student_fee_account")]
[Index("StudentId", Name = "idx_student_fee_account_student")]
public partial class StudentFeeAccount
{
    [Key]
    [Column("account_id", TypeName = "int(11)")]
    public int AccountId { get; set; }

    [Column("student_id", TypeName = "int(11)")]
    public int? StudentId { get; set; }

    [Column("balance")]
    [Precision(10, 2)]
    public decimal? Balance { get; set; }

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    [ForeignKey("StudentId")]
    [InverseProperty("StudentFeeAccounts")]
    public virtual Student? Student { get; set; }
}
