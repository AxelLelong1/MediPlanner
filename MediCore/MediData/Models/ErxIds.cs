using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("erx_ids")]
[Index("ErxSegRefId", Name = "nc1_erx_ids")]
public partial class ErxIds
{
    [Key]
    [Column("erx_id_id")]
    public int ErxIdId { get; set; }

    [Column("erx_seg_ref_id")]
    public int? ErxSegRefId { get; set; }

    [Column("erx_seg")]
    [StringLength(5)]
    public string? ErxSeg { get; set; }

    [Column("id_value")]
    [StringLength(80)]
    public string? IdValue { get; set; }

    [Column("id_value_cd")]
    [StringLength(30)]
    public string? IdValueCd { get; set; }

    [Column("msg_typ")]
    [StringLength(8)]
    public string? MsgTyp { get; set; }
}
