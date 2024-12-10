using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("img_paper_cfg")]
public partial class ImgPaperCfg
{
    [Key]
    [Column("paper_cfg_id")]
    [StringLength(10)]
    public string PaperCfgId { get; set; } = null!;

    [Column("paper_dflt_id")]
    public int PaperDfltId { get; set; }

    [Column("scan_mode_id")]
    public int ScanModeId { get; set; }

    [Column("form_desc")]
    [StringLength(255)]
    public string FormDesc { get; set; } = null!;

    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Column("resolution")]
    public int? Resolution { get; set; }

    [Column("brightness")]
    public int? Brightness { get; set; }

    [Column("contrast")]
    public int? Contrast { get; set; }

    [Column("duplex_ind")]
    [StringLength(1)]
    public string? DuplexInd { get; set; }

    [Column("dflt_ind")]
    [StringLength(1)]
    public string? DfltInd { get; set; }

    [Column("paper_top", TypeName = "decimal(8, 3)")]
    public decimal? PaperTop { get; set; }

    [Column("paper_left", TypeName = "decimal(8, 3)")]
    public decimal? PaperLeft { get; set; }

    [Column("paper_right", TypeName = "decimal(8, 3)")]
    public decimal? PaperRight { get; set; }

    [Column("paper_bottom", TypeName = "decimal(8, 3)")]
    public decimal? PaperBottom { get; set; }

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

    [ForeignKey("PaperDfltId")]
    [InverseProperty("ImgPaperCfg")]
    public virtual ImgPaperDflt PaperDflt { get; set; } = null!;

    [ForeignKey("ScanModeId")]
    [InverseProperty("ImgPaperCfg")]
    public virtual ImgScanMode ScanMode { get; set; } = null!;
}
