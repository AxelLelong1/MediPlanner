using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("fcn_typ")]
public partial class FcnTyp
{
    [Key]
    [Column("fcn_typ")]
    public int FcnTyp1 { get; set; }

    [Column("fcn_cls")]
    public int FcnCls { get; set; }

    [Column("fcn_name")]
    [StringLength(30)]
    public string FcnName { get; set; } = null!;

    [Column("fcn_comp")]
    [StringLength(30)]
    public string FcnComp { get; set; } = null!;

    [Column("fcn_desc")]
    [StringLength(255)]
    public string FcnDesc { get; set; } = null!;

    [Column("active_ind")]
    [StringLength(1)]
    public string? ActiveInd { get; set; }

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

    [InverseProperty("FcnTypNavigation")]
    public virtual ICollection<FcnDetail> FcnDetail { get; set; } = new List<FcnDetail>();
}
