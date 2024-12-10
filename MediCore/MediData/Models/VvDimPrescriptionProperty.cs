using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimPrescriptionProperty
{
    public short PropertyType { get; set; }

    [StringLength(64)]
    public string PropertyValue { get; set; } = null!;

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    public short? ItemType { get; set; }

    [StringLength(64)]
    public string? ItemValue { get; set; }

    [Column("ctrPrescriptionPropertySer")]
    public long CtrPrescriptionPropertySer { get; set; }

    [Column("ctrPrescriptionPropertyItemSer")]
    public long CtrPrescriptionPropertyItemSer { get; set; }

    [Column("ctrPrescriptionSer")]
    public long CtrPrescriptionSer { get; set; }
}
