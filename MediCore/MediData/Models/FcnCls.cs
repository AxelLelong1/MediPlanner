using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("fcn_cls")]
public partial class FcnCls
{
    [Key]
    [Column("fcn_cls")]
    public int FcnCls1 { get; set; }

    [Column("fcn_cls_desc")]
    [StringLength(30)]
    public string FcnClsDesc { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("formula_dsp_ind")]
    [StringLength(1)]
    public string? FormulaDspInd { get; set; }
}
