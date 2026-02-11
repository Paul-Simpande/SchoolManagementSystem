using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("network_uptime")]
[Index("StatusId", Name = "idx_network_status")]
public partial class NetworkUptime
{
    [Key]
    [Column("uptime_id", TypeName = "int(11)")]
    public int UptimeId { get; set; }

    [Column("check_time", TypeName = "datetime")]
    public DateTime? CheckTime { get; set; }

    [Column("status_id", TypeName = "int(11)")]
    public int StatusId { get; set; }

    [ForeignKey("StatusId")]
    [InverseProperty("NetworkUptimes")]
    public virtual UptimeStatus Status { get; set; } = null!;
}
