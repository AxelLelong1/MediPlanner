using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("iv_cat_resp")]
public partial class IvCatResp
{
    [Key]
    [Column("iv_cat_resp_id")]
    public int IvCatRespId { get; set; }

    [Column("iv_cat_resp_desc")]
    [StringLength(100)]
    public string IvCatRespDesc { get; set; } = null!;

    [Column("iv_cat_resp_dsp_desc")]
    [StringLength(100)]
    public string IvCatRespDspDesc { get; set; } = null!;

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

    [InverseProperty("IvCatResp")]
    public virtual ICollection<IvQstrResp> IvQstrResp { get; set; } = new List<IvQstrResp>();
}
