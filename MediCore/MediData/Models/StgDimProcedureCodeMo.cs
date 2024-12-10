using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimProcedureCode_MO", Schema = "DWH")]
public partial class StgDimProcedureCodeMo
{
    [Column("bill_cd")]
    [StringLength(60)]
    public string? BillCd { get; set; }

    [Column("bill_cd_typ_id")]
    public int? BillCdTypId { get; set; }
}
