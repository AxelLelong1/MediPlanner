using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "TrfDirctn")]
[Table("trf_inst")]
public partial class TrfInst
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("trf_dirctn")]
    [StringLength(10)]
    public string TrfDirctn { get; set; } = null!;

    [Column("trf_mgr")]
    [StringLength(1)]
    public string TrfMgr { get; set; } = null!;

    [Column("trf_plnr")]
    [StringLength(1)]
    public string TrfPlnr { get; set; } = null!;

    [Column("trf_data_anon")]
    [StringLength(1)]
    public string TrfDataAnon { get; set; } = null!;

    [Column("trf_file_name")]
    [StringLength(6)]
    public string TrfFileName { get; set; } = null!;

    [Column("trf_file_dir")]
    [StringLength(100)]
    public string TrfFileDir { get; set; } = null!;

    [Column("trf_share_point")]
    [StringLength(100)]
    public string? TrfSharePoint { get; set; }

    [Column("remote_file_dir")]
    [StringLength(100)]
    public string? RemoteFileDir { get; set; }

    [Column("compr_file_flag")]
    [StringLength(1)]
    public string ComprFileFlag { get; set; } = null!;

    [Column("virus_scan")]
    [StringLength(1)]
    public string VirusScan { get; set; } = null!;

    [Column("ignore_log")]
    [StringLength(1)]
    public string IgnoreLog { get; set; } = null!;

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

    [Column("trf_share_point_domain")]
    [StringLength(60)]
    public string? TrfSharePointDomain { get; set; }

    [ForeignKey("InstId")]
    [InverseProperty("TrfInst")]
    public virtual Inst Inst { get; set; } = null!;

    [InverseProperty("TrfInst")]
    public virtual ICollection<TrfColToOvride> TrfColToOvride { get; set; } = new List<TrfColToOvride>();

    [InverseProperty("TrfInst")]
    public virtual ICollection<TrfCondRuleInst> TrfCondRuleInst { get; set; } = new List<TrfCondRuleInst>();

    [InverseProperty("TrfInst")]
    public virtual ICollection<TrfExclTransLogNulls> TrfExclTransLogNulls { get; set; } = new List<TrfExclTransLogNulls>();

    [InverseProperty("TrfInst")]
    public virtual ICollection<TrfLog> TrfLog { get; set; } = new List<TrfLog>();

    [InverseProperty("TrfInst")]
    public virtual ICollection<TrfSync> TrfSync { get; set; } = new List<TrfSync>();

    [InverseProperty("TrfInst")]
    public virtual ICollection<TrfTblToBlock> TrfTblToBlock { get; set; } = new List<TrfTblToBlock>();
}
