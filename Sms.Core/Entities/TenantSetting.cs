using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("tenant_setting")]
[Index("SchoolId", "SettingKey", Name = "school_id", IsUnique = true)]
public partial class TenantSetting
{
    [Key]
    [Column("setting_id", TypeName = "int(11)")]
    public int SettingId { get; set; }

    [Column("school_id", TypeName = "int(11)")]
    public int SchoolId { get; set; }

    [Column("setting_key")]
    [StringLength(100)]
    public string SettingKey { get; set; } = null!;

    [Column("setting_value", TypeName = "text")]
    public string? SettingValue { get; set; }

    [ForeignKey("SchoolId")]
    [InverseProperty("TenantSettings")]
    public virtual School School { get; set; } = null!;
}
