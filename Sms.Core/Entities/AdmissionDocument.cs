using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("admission_document")]
[Index("ApplicationId", Name = "application_id")]
public partial class AdmissionDocument
{
    [Key]
    [Column("document_id", TypeName = "int(11)")]
    public int DocumentId { get; set; }

    [Column("application_id", TypeName = "int(11)")]
    public int? ApplicationId { get; set; }

    [Column("document_type")]
    [StringLength(100)]
    public string? DocumentType { get; set; }

    [Column("file_path", TypeName = "text")]
    public string? FilePath { get; set; }

    [ForeignKey("ApplicationId")]
    [InverseProperty("AdmissionDocuments")]
    public virtual AdmissionApplication? Application { get; set; }
}
