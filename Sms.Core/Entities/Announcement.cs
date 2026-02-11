using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("announcement")]
[Index("SchoolId", Name = "idx_announcement_school")]
public partial class Announcement
{
    [Key]
    [Column("announcement_id", TypeName = "int(11)")]
    public int AnnouncementId { get; set; }

    [Column("school_id", TypeName = "int(11)")]
    public int? SchoolId { get; set; }

    [Column("title")]
    [StringLength(150)]
    public string? Title { get; set; }

    [Column("content", TypeName = "text")]
    public string? Content { get; set; }

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    [Column("is_deleted")]
    public bool? IsDeleted { get; set; }

    [Column("deleted_at", TypeName = "datetime")]
    public DateTime? DeletedAt { get; set; }

    [ForeignKey("SchoolId")]
    [InverseProperty("Announcements")]
    public virtual School? School { get; set; }
}
