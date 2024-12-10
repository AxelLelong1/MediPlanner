using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("img_paper_dflt")]
public partial class ImgPaperDflt
{
    [Key]
    [Column("paper_dflt_id")]
    public int PaperDfltId { get; set; }

    [Column("paper_id")]
    public int PaperId { get; set; }

    [Column("paper_desc")]
    [StringLength(255)]
    public string? PaperDesc { get; set; }

    [Column("resolution")]
    public int? Resolution { get; set; }

    [Column("brightness")]
    public int? Brightness { get; set; }

    [Column("contrast")]
    public int? Contrast { get; set; }

    [Column("duplex_ind")]
    [StringLength(1)]
    public string? DuplexInd { get; set; }

    [Column("paper_top", TypeName = "decimal(8, 3)")]
    public decimal? PaperTop { get; set; }

    [Column("paper_left", TypeName = "decimal(8, 3)")]
    public decimal? PaperLeft { get; set; }

    [Column("paper_right", TypeName = "decimal(8, 3)")]
    public decimal? PaperRight { get; set; }

    [Column("paper_bottom", TypeName = "decimal(8, 3)")]
    public decimal? PaperBottom { get; set; }

    [Column("show_user_ind")]
    [StringLength(1)]
    public string? ShowUserInd { get; set; }

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

    [InverseProperty("PaperDflt")]
    public virtual ICollection<ImgPaperCfg> ImgPaperCfg { get; set; } = new List<ImgPaperCfg>();
}
