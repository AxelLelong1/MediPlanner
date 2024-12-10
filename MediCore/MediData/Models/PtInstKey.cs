using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtInstKeyId")]
[Table("pt_inst_key")]
[Index("UpperPtKeyValue", Name = "nc1_pt_inst_key")]
[Index("InstId", "PtKeyCd", "PtKeyValue", "PtId", Name = "nc2_pt_inst_key")]
[Index("InstId", "PtKeyCd", "UpperPtKeyValue", Name = "nc3_pt_inst_key")]
[Index("PtId", "InstId", "PtKeyCd", "CurValueInd", "PtKeyValue", Name = "nc4_pt_inst_key")]
[Index("PtKeyCd", "CurValueInd", "PtId", "PtInstKeyId", "InstId", "ValidEntryInd", Name = "nc5_pt_inst_key")]
[Index("PtKeyCd", "CurValueInd", "ValidEntryInd", "PtId", Name = "nc6_pt_inst_key")]
public partial class PtInstKey
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_inst_key_id")]
    public int PtInstKeyId { get; set; }

    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Column("pt_key_cd")]
    public int PtKeyCd { get; set; }

    [Column("pt_key_value")]
    [StringLength(25)]
    public string PtKeyValue { get; set; } = null!;

    [Column("eff_date", TypeName = "datetime")]
    public DateTime EffDate { get; set; }

    [Column("expiry_date", TypeName = "datetime")]
    public DateTime ExpiryDate { get; set; }

    [Column("cur_value_ind")]
    [StringLength(1)]
    public string CurValueInd { get; set; } = null!;

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

    [Column("upper_pt_key_value")]
    [StringLength(25)]
    public string? UpperPtKeyValue { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("pt_unfmt_key_value")]
    [StringLength(25)]
    public string? PtUnfmtKeyValue { get; set; }

    [ForeignKey("PtKeyCd")]
    [InverseProperty("PtInstKey")]
    public virtual PtKeyCd PtKeyCdNavigation { get; set; } = null!;
}
