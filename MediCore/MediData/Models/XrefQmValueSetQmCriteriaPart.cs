using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("QmId", "ValueSet", "QmcpTyp")]
[Table("xref_qm_value_set_qm_criteria_part")]
public partial class XrefQmValueSetQmCriteriaPart
{
    [Key]
    [Column("qm_id")]
    public int QmId { get; set; }

    [Key]
    [Column("value_set")]
    [StringLength(254)]
    public string ValueSet { get; set; } = null!;

    [Key]
    [Column("qmcp_typ")]
    [StringLength(50)]
    public string QmcpTyp { get; set; } = null!;

    [Column("qrda_cat_cd")]
    [StringLength(10)]
    public string QrdaCatCd { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

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
}
