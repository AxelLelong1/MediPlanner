using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtIvId", "IvQstrCatId")]
[Table("pt_iv_resp")]
public partial class PtIvResp
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_iv_id")]
    public int PtIvId { get; set; }

    [Key]
    [Column("iv_qstr_cat_id")]
    public int IvQstrCatId { get; set; }

    [Column("iv_qstr_id")]
    public int IvQstrId { get; set; }

    [Column("pt_visit_id")]
    public int PtVisitId { get; set; }

    [Column("resp")]
    [StringLength(255)]
    public string? Resp { get; set; }

    [Column("resp_txt")]
    public string? RespTxt { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [ForeignKey("IvQstrId, IvQstrCatId")]
    [InverseProperty("PtIvResp")]
    public virtual IvQstrCat IvQstrCat { get; set; } = null!;

    [ForeignKey("PtId, PtIvId")]
    [InverseProperty("PtIvResp")]
    public virtual PtIv PtIv { get; set; } = null!;

    [InverseProperty("PtIvResp")]
    public virtual ICollection<PtIvRespItem> PtIvRespItem { get; set; } = new List<PtIvRespItem>();
}
