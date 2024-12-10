using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "FacId", "FacRqstnNo", "FacRqstnCatNo")]
[Table("fac_rqstn_cat")]
public partial class FacRqstnCat
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("fac_id")]
    public int FacId { get; set; }

    [Key]
    [Column("fac_rqstn_no")]
    [StringLength(20)]
    public string FacRqstnNo { get; set; } = null!;

    [Key]
    [Column("fac_rqstn_cat_no")]
    public int FacRqstnCatNo { get; set; }

    [Column("fac_rqstn_order_no")]
    public int FacRqstnOrderNo { get; set; }

    [Column("fac_rqstn_cat_desc")]
    [StringLength(40)]
    public string FacRqstnCatDesc { get; set; } = null!;

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
    public string TransLogMuserid { get; set; } = null!;

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string TransLogMinstId { get; set; } = null!;

    [Column("active_ind")]
    [StringLength(1)]
    public string? ActiveInd { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("result_cat_order")]
    public int? ResultCatOrder { get; set; }

    [ForeignKey("InstId, FacId, FacRqstnNo")]
    [InverseProperty("FacRqstnCat")]
    public virtual FacRqstn FacRqstn { get; set; } = null!;

    [InverseProperty("FacRqstnCat")]
    public virtual ICollection<XrefCatGroup> XrefCatGroup { get; set; } = new List<XrefCatGroup>();
}
