using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("fac_group_map")]
public partial class FacGroupMap
{
    [Key]
    [Column("fac_grp_map_seq")]
    public int FacGrpMapSeq { get; set; }

    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Column("fac_id")]
    public int FacId { get; set; }

    [Column("fac_group_id")]
    public int FacGroupId { get; set; }

    [Column("mapping_typ")]
    [StringLength(2)]
    public string MappingTyp { get; set; } = null!;

    [Column("mapping_cd")]
    [StringLength(30)]
    public string MappingCd { get; set; } = null!;

    [Column("eff_date", TypeName = "datetime")]
    public DateTime? EffDate { get; set; }

    [Column("term_date", TypeName = "datetime")]
    public DateTime? TermDate { get; set; }

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

    [ForeignKey("InstId, FacId, FacGroupId")]
    [InverseProperty("FacGroupMap")]
    public virtual FacGroup FacGroup { get; set; } = null!;
}
