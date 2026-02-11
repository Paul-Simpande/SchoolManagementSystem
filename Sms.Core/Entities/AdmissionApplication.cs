using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("admission_application")]
[Index("SchoolId", Name = "school_id")]
[Index("StatusId", Name = "status_id")]
public partial class AdmissionApplication
{
    [Key]
    [Column("application_id", TypeName = "int(11)")]
    public int ApplicationId { get; set; }

    [Column("school_id", TypeName = "int(11)")]
    public int? SchoolId { get; set; }

    [Column("applicant_name")]
    [StringLength(150)]
    public string? ApplicantName { get; set; }

    [Column("status_id", TypeName = "int(11)")]
    public int StatusId { get; set; }

    [Column("submitted_at", TypeName = "datetime")]
    public DateTime? SubmittedAt { get; set; }

    [InverseProperty("Application")]
    public virtual ICollection<AdmissionDocument> AdmissionDocuments { get; set; } = new List<AdmissionDocument>();

    [ForeignKey("SchoolId")]
    [InverseProperty("AdmissionApplications")]
    public virtual School? School { get; set; }

    [ForeignKey("StatusId")]
    [InverseProperty("AdmissionApplications")]
    public virtual AdmissionStatus Status { get; set; } = null!;
}
