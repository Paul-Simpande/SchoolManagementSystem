using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("assignment_file")]
[Index("AssignmentId", Name = "assignment_id")]
public partial class AssignmentFile
{
    [Key]
    [Column("file_id", TypeName = "int(11)")]
    public int FileId { get; set; }

    [Column("assignment_id", TypeName = "int(11)")]
    public int AssignmentId { get; set; }

    [Column("file_path", TypeName = "text")]
    public string? FilePath { get; set; }

    [Column("uploaded_at", TypeName = "datetime")]
    public DateTime? UploadedAt { get; set; }

    [ForeignKey("AssignmentId")]
    [InverseProperty("AssignmentFiles")]
    public virtual Assignment Assignment { get; set; } = null!;
}
