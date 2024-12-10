using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgFactPhysicianOrderErrorData", Schema = "DWH")]
public partial class StgFactPhysicianOrderErrorData
{
    [Column("pt_id")]
    [StringLength(20)]
    public string? PtId { get; set; }

    [Column("vrbl_id")]
    public int? VrblId { get; set; }

    [Column("vrbl_order_detail_id")]
    public int? VrblOrderDetailId { get; set; }
}
