using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("IvQstrId", "IvQstrCatId")]
[Table("iv_qstr_cat")]
public partial class IvQstrCat
{
    [Key]
    [Column("iv_qstr_id")]
    public int IvQstrId { get; set; }

    [Key]
    [Column("iv_qstr_cat_id")]
    public int IvQstrCatId { get; set; }

    [Column("iv_cat_hdr_id")]
    public int? IvCatHdrId { get; set; }

    [Column("iv_cat_id")]
    public int? IvCatId { get; set; }

    [Column("iv_resp_typ_id")]
    public int? IvRespTypId { get; set; }

    [Column("iv_cat_seq_no")]
    public int? IvCatSeqNo { get; set; }

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

    [ForeignKey("IvQstrId")]
    [InverseProperty("IvQstrCat")]
    public virtual IvQstr IvQstr { get; set; } = null!;

    [InverseProperty("IvQstrCat")]
    public virtual IvQstrBmp? IvQstrBmp { get; set; }

    [InverseProperty("IvQstrCat")]
    public virtual ICollection<IvQstrResp> IvQstrResp { get; set; } = new List<IvQstrResp>();

    [ForeignKey("IvRespTypId")]
    [InverseProperty("IvQstrCat")]
    public virtual IvRespTyp? IvRespTyp { get; set; }

    [InverseProperty("IvQstrCat")]
    public virtual ICollection<PtIvResp> PtIvResp { get; set; } = new List<PtIvResp>();
}
