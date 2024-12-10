using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimPrescriptionAnatomy
{
    public short AnatomyRole { get; set; }

    [StringLength(256)]
    public string AnatomyName { get; set; } = null!;

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [StringLength(64)]
    public string? ItemType { get; set; }

    [StringLength(64)]
    public string? ItemValue { get; set; }

    [StringLength(16)]
    public string? ItemValueUnit { get; set; }

    [StringLength(64)]
    public string? Param1Value { get; set; }

    [StringLength(16)]
    public string? Param1ValueUnit { get; set; }

    [Column("ctrPrescriptionAnatomySer")]
    public long CtrPrescriptionAnatomySer { get; set; }

    [Column("ctrPrescriptionAnatomyItemSer")]
    public long CtrPrescriptionAnatomyItemSer { get; set; }

    [Column("ctrPrescriptionSer")]
    public long CtrPrescriptionSer { get; set; }
}
