using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "FacId", "FacGroupId", "FacRqstnNo", "FacRqstnCatNo")]
[Table("xref_cat_group")]
public partial class XrefCatGroup
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("fac_id")]
    public int FacId { get; set; }

    [Key]
    [Column("fac_group_id")]
    public int FacGroupId { get; set; }

    [Key]
    [Column("fac_rqstn_no")]
    [StringLength(20)]
    public string FacRqstnNo { get; set; } = null!;

    [Key]
    [Column("fac_rqstn_cat_no")]
    public int FacRqstnCatNo { get; set; }

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

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("result_group_order")]
    public int? ResultGroupOrder { get; set; }

    [Column("group_order_no")]
    public int? GroupOrderNo { get; set; }

    [ForeignKey("InstId, FacId, FacGroupId")]
    [InverseProperty("XrefCatGroup")]
    public virtual FacGroup FacGroup { get; set; } = null!;

    [ForeignKey("InstId, FacId, FacRqstnNo, FacRqstnCatNo")]
    [InverseProperty("XrefCatGroup")]
    public virtual FacRqstnCat FacRqstnCat { get; set; } = null!;
}
