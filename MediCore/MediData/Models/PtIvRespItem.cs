using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtIvId", "IvQstrCatId", "IvCatRespId")]
[Table("pt_iv_resp_item")]
public partial class PtIvRespItem
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

    [Key]
    [Column("iv_cat_resp_id")]
    public int IvCatRespId { get; set; }

    [Column("pt_visit_id")]
    public int PtVisitId { get; set; }

    [Column("iv_qstr_id")]
    public int IvQstrId { get; set; }

    [Column("resp")]
    [StringLength(255)]
    public string? Resp { get; set; }

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

    [ForeignKey("IvQstrId, IvQstrCatId, IvCatRespId")]
    [InverseProperty("PtIvRespItem")]
    public virtual IvQstrResp IvQstrResp { get; set; } = null!;

    [ForeignKey("PtId, PtIvId, IvQstrCatId")]
    [InverseProperty("PtIvRespItem")]
    public virtual PtIvResp PtIvResp { get; set; } = null!;
}
