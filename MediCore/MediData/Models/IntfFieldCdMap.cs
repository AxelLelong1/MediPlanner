using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("IntfAppParmId", "IntfFieldCdMapId")]
[Table("intf_field_cd_map")]
public partial class IntfFieldCdMap
{
    [Key]
    [Column("intf_field_cd_map_id")]
    [StringLength(10)]
    public string IntfFieldCdMapId { get; set; } = null!;

    [Key]
    [Column("intf_app_parm_id")]
    [StringLength(10)]
    public string IntfAppParmId { get; set; } = null!;

    [Column("seg_field_xref_id")]
    [StringLength(10)]
    public string SegFieldXrefId { get; set; } = null!;

    [Column("sort_order_no")]
    public int? SortOrderNo { get; set; }

    [Column("map_typ")]
    [StringLength(3)]
    public string MapTyp { get; set; } = null!;

    [Column("key_cd")]
    [StringLength(20)]
    public string KeyCd { get; set; } = null!;

    [Column("key_typ")]
    [StringLength(20)]
    public string KeyTyp { get; set; } = null!;

    [Column("external_typ")]
    [StringLength(30)]
    public string? ExternalTyp { get; set; }

    [Column("external_desc")]
    [StringLength(60)]
    public string? ExternalDesc { get; set; }

    [Column("pref_ind")]
    [StringLength(1)]
    public string? PrefInd { get; set; }

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

    [ForeignKey("IntfAppParmId")]
    [InverseProperty("IntfFieldCdMap")]
    public virtual IntfAppParm IntfAppParm { get; set; } = null!;
}
