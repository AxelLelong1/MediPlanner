using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("GnrcGrpId", "TrGrpId", "TrGrpCompId", "InstId")]
[Table("tr_grp_comp")]
public partial class TrGrpComp
{
    [Key]
    [Column("gnrc_grp_id")]
    public int GnrcGrpId { get; set; }

    [Key]
    [Column("tr_grp_id")]
    public int TrGrpId { get; set; }

    [Key]
    [Column("tr_grp_comp_id")]
    public int TrGrpCompId { get; set; }

    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Column("tr_comp_id")]
    public int TrCompId { get; set; }

    [Column("tr_sub_comp_id")]
    public int? TrSubCompId { get; set; }

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

    [ForeignKey("GnrcGrpId, TrGrpId, InstId")]
    [InverseProperty("TrGrpComp")]
    public virtual TrGrp TrGrp { get; set; } = null!;
}
