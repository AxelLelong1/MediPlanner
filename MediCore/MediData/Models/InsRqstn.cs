using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "InsCoParentId", "FacInstId", "FacId", "FacRqstnNo")]
[Table("ins_rqstn")]
public partial class InsRqstn
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("ins_co_parent_id")]
    public int InsCoParentId { get; set; }

    [Key]
    [Column("fac_inst_id")]
    [StringLength(30)]
    public string FacInstId { get; set; } = null!;

    [Key]
    [Column("fac_id")]
    public int FacId { get; set; }

    [Key]
    [Column("fac_rqstn_no")]
    [StringLength(20)]
    public string FacRqstnNo { get; set; } = null!;

    [Column("rqstn_seq_no")]
    public int RqstnSeqNo { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string TransLogMuserid { get; set; } = null!;

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string TransLogMinstId { get; set; } = null!;

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime TransLogMtstamp { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("ins_rqstn_eff_date", TypeName = "datetime")]
    public DateTime? InsRqstnEffDate { get; set; }

    [Column("ins_rqstn_exp_date", TypeName = "datetime")]
    public DateTime? InsRqstnExpDate { get; set; }

    [ForeignKey("FacInstId, FacId, FacRqstnNo")]
    [InverseProperty("InsRqstn")]
    public virtual FacRqstn FacRqstn { get; set; } = null!;

    [ForeignKey("InstId, InsCoParentId")]
    [InverseProperty("InsRqstn")]
    public virtual InsCoParent InsCoParent { get; set; } = null!;
}
