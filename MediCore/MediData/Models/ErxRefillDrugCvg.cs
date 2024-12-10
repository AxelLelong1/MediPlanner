using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("erx_refill_drug_cvg")]
public partial class ErxRefillDrugCvg
{
    [Key]
    [Column("erx_drug_cvg_id")]
    public int ErxDrugCvgId { get; set; }

    [Column("erx_seg_ref_id")]
    public int? ErxSegRefId { get; set; }

    [Column("drug_cvg_status_cd")]
    [StringLength(2)]
    public string? DrugCvgStatusCd { get; set; }

    [Column("msg_typ")]
    [StringLength(8)]
    public string? MsgTyp { get; set; }
}
