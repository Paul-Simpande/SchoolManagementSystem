using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("event_calendar")]
[Index("SchoolId", Name = "idx_event_school")]
public partial class EventCalendar
{
    [Key]
    [Column("event_id", TypeName = "int(11)")]
    public int EventId { get; set; }

    [Column("school_id", TypeName = "int(11)")]
    public int? SchoolId { get; set; }

    [Column("event_title")]
    [StringLength(150)]
    public string? EventTitle { get; set; }

    [Column("event_date")]
    public DateOnly? EventDate { get; set; }

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    [Column("is_deleted")]
    public bool? IsDeleted { get; set; }

    [Column("deleted_at", TypeName = "datetime")]
    public DateTime? DeletedAt { get; set; }

    [ForeignKey("SchoolId")]
    [InverseProperty("EventCalendars")]
    public virtual School? School { get; set; }
}
