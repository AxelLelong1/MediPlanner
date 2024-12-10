using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("IvQstrId", "IvQstrCatId", "IvCatRespId")]
[Table("iv_qstr_resp")]
public partial class IvQstrResp
{
    [Key]
    [Column("iv_qstr_id")]
    public int IvQstrId { get; set; }

    [Key]
    [Column("iv_qstr_cat_id")]
    public int IvQstrCatId { get; set; }

    [Key]
    [Column("iv_cat_resp_id")]
    public int IvCatRespId { get; set; }

    [Column("iv_resp_seq_no")]
    public int? IvRespSeqNo { get; set; }

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

    [ForeignKey("IvCatRespId")]
    [InverseProperty("IvQstrResp")]
    public virtual IvCatResp IvCatResp { get; set; } = null!;

    [ForeignKey("IvQstrId, IvQstrCatId")]
    [InverseProperty("IvQstrResp")]
    public virtual IvQstrCat IvQstrCat { get; set; } = null!;

    [InverseProperty("IvQstrResp")]
    public virtual ICollection<PtIvRespItem> PtIvRespItem { get; set; } = new List<PtIvRespItem>();
}
