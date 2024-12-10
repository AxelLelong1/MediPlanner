using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimDxSite", Schema = "DWH")]
public partial class StgDimDxSite1
{
    [Column("tp_cls_typ_id")]
    public int? TpClsTypId { get; set; }

    [Column("tp_cls_value_id")]
    public int? TpClsValueId { get; set; }
}
