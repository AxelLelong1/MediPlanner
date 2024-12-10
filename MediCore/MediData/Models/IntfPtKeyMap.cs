using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("IntfAppParmId", "IntfPtKeyMapId")]
[Table("intf_pt_key_map")]
public partial class IntfPtKeyMap
{
    [Key]
    [Column("intf_app_parm_id")]
    [StringLength(10)]
    public string IntfAppParmId { get; set; } = null!;

    [Key]
    [Column("intf_pt_key_map_id")]
    [StringLength(10)]
    public string IntfPtKeyMapId { get; set; } = null!;

    [Column("seg_field_xref_id")]
    [StringLength(10)]
    public string SegFieldXrefId { get; set; } = null!;

    [Column("pt_id_typ_cd")]
    [StringLength(30)]
    public string? PtIdTypCd { get; set; }

    [Column("pt_id_typ_desc")]
    [StringLength(60)]
    public string? PtIdTypDesc { get; set; }

    [Column("pt_key_cd")]
    public int PtKeyCd { get; set; }

    [Column("pt_key_cd_inst_id")]
    [StringLength(30)]
    public string PtKeyCdInstId { get; set; } = null!;

    [Column("pt_id_prcs_flag")]
    [StringLength(1)]
    public string PtIdPrcsFlag { get; set; } = null!;

    [Column("pt_id_match_ind")]
    [StringLength(1)]
    public string PtIdMatchInd { get; set; } = null!;

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

    [Column("allow_update_ind")]
    [StringLength(1)]
    public string? AllowUpdateInd { get; set; }

    [Column("trim_char")]
    [StringLength(1)]
    public string? TrimChar { get; set; }

    [Column("trim_blank_ind")]
    [StringLength(1)]
    public string? TrimBlankInd { get; set; }

    [Column("trim_leading_no_char")]
    public int? TrimLeadingNoChar { get; set; }

    [Column("pad_with_char")]
    [StringLength(1)]
    public string? PadWithChar { get; set; }

    [Column("pad_char_to_len")]
    public int? PadCharToLen { get; set; }

    [Column("display_key_1_ind")]
    [StringLength(1)]
    public string? DisplayKey1Ind { get; set; }

    [Column("display_key_2_ind")]
    [StringLength(1)]
    public string? DisplayKey2Ind { get; set; }

    [ForeignKey("PtKeyCdInstId, PtKeyCd")]
    [InverseProperty("IntfPtKeyMap")]
    public virtual InstPtKeyCd InstPtKeyCd { get; set; } = null!;

    [ForeignKey("IntfAppParmId")]
    [InverseProperty("IntfPtKeyMap")]
    public virtual IntfAppParm IntfAppParm { get; set; } = null!;

    [ForeignKey("SegFieldXrefId")]
    [InverseProperty("IntfPtKeyMap")]
    public virtual Hl7SegFieldXref SegFieldXref { get; set; } = null!;
}
