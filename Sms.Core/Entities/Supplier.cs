using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sms.Core.Entities;

[Table("supplier")]
[Index("SchoolId", Name = "idx_supplier_school")]
[Index("StatusId", Name = "idx_supplier_status")]
[Index("SupplierCode", Name = "supplier_code", IsUnique = true)]
[Index("SupplierTypeId", Name = "supplier_type_id")]
public partial class Supplier
{
    [Key]
    [Column("supplier_id", TypeName = "int(11)")]
    public int SupplierId { get; set; }

    [Column("school_id", TypeName = "int(11)")]
    public int SchoolId { get; set; }

    [Column("supplier_code")]
    [StringLength(50)]
    public string? SupplierCode { get; set; }

    [Column("supplier_name")]
    [StringLength(150)]
    public string SupplierName { get; set; } = null!;

    [Column("contact_person")]
    [StringLength(150)]
    public string? ContactPerson { get; set; }

    [Column("phone")]
    [StringLength(30)]
    public string? Phone { get; set; }

    [Column("email")]
    [StringLength(150)]
    public string? Email { get; set; }

    [Column("address", TypeName = "text")]
    public string? Address { get; set; }

    [Column("tax_number")]
    [StringLength(50)]
    public string? TaxNumber { get; set; }

    [Column("supplier_type_id", TypeName = "int(11)")]
    public int SupplierTypeId { get; set; }

    [Column("status_id", TypeName = "int(11)")]
    public int StatusId { get; set; }

    [Column("created_at", TypeName = "datetime")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    [InverseProperty("Supplier")]
    public virtual ICollection<ProcurementRequest> ProcurementRequests { get; set; } = new List<ProcurementRequest>();

    [InverseProperty("Supplier")]
    public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; } = new List<PurchaseOrder>();

    [ForeignKey("SchoolId")]
    [InverseProperty("Suppliers")]
    public virtual School School { get; set; } = null!;

    [ForeignKey("StatusId")]
    [InverseProperty("Suppliers")]
    public virtual SupplierStatus Status { get; set; } = null!;

    [ForeignKey("SupplierTypeId")]
    [InverseProperty("Suppliers")]
    public virtual SupplierType SupplierType { get; set; } = null!;
}
