using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("GnrcGrpId", "TrGrpId", "InstId")]
[Table("tr_grp")]
public partial class TrGrp
{
    [Key]
    [Column("gnrc_grp_id")]
    public int GnrcGrpId { get; set; }

    [Key]
    [Column("tr_grp_id")]
    public int TrGrpId { get; set; }

    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Column("cls_scheme_id")]
    public int ClsSchemeId { get; set; }

    [Column("tr_grp_seq_no")]
    public int TrGrpSeqNo { get; set; }

    [Column("active_ind")]
    [StringLength(1)]
    public string ActiveInd { get; set; } = null!;

    [Column("default_ind")]
    [StringLength(1)]
    public string DefaultInd { get; set; } = null!;

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

    [ForeignKey("GnrcGrpId")]
    [InverseProperty("TrGrp")]
    public virtual GnrcGrp GnrcGrp { get; set; } = null!;

    [InverseProperty("TrGrp")]
    public virtual ICollection<TrGrpComp> TrGrpComp { get; set; } = new List<TrGrpComp>();
}
