using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("backup")]
[Index("SchoolId", Name = "idx_backup_school")]
[Index("StatusId", Name = "idx_backup_status")]
public partial class Backup
{
    [Key]
    [Column("backup_id", TypeName = "int(11)")]
    public int BackupId { get; set; }

    [Column("school_id", TypeName = "int(11)")]
    public int? SchoolId { get; set; }

    [Column("backup_date", TypeName = "datetime")]
    public DateTime? BackupDate { get; set; }

    [Column("status_id", TypeName = "int(11)")]
    public int StatusId { get; set; }

    [ForeignKey("SchoolId")]
    [InverseProperty("Backups")]
    public virtual School? School { get; set; }

    [ForeignKey("StatusId")]
    [InverseProperty("Backups")]
    public virtual BackupStatus Status { get; set; } = null!;
}
