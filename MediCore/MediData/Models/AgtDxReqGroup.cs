using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "AgtDxReqGroupId", "AgtDxReqCompId")]
[Table("agt_dx_req_group")]
public partial class AgtDxReqGroup
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("agt_dx_req_group_id")]
    public int AgtDxReqGroupId { get; set; }

    [Key]
    [Column("agt_dx_req_comp_id")]
    public int AgtDxReqCompId { get; set; }

    [Column("from_icd_cd")]
    [StringLength(16)]
    public string FromIcdCd { get; set; } = null!;

    [Column("to_icd_cd")]
    [StringLength(16)]
    public string? ToIcdCd { get; set; }

    [Column("cls_scheme_id")]
    public int ClsSchemeId { get; set; }

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
}
