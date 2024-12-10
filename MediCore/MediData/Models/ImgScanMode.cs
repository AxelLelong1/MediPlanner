using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("img_scan_mode")]
public partial class ImgScanMode
{
    [Key]
    [Column("scan_mode_id")]
    public int ScanModeId { get; set; }

    [Column("scan_mode")]
    public int ScanMode { get; set; }

    [Column("scan_desc")]
    [StringLength(255)]
    public string? ScanDesc { get; set; }

    [Column("scan_note")]
    [StringLength(255)]
    public string? ScanNote { get; set; }

    [Column("show_user_ind")]
    [StringLength(1)]
    public string? ShowUserInd { get; set; }

    [Column("dflt_ind")]
    [StringLength(1)]
    public string? DfltInd { get; set; }

    [Column("file_typ")]
    public int? FileTyp { get; set; }

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

    [ForeignKey("FileTyp")]
    [InverseProperty("ImgScanMode")]
    public virtual ImgFileTyp? FileTypNavigation { get; set; }

    [InverseProperty("ScanMode")]
    public virtual ICollection<ImgPaperCfg> ImgPaperCfg { get; set; } = new List<ImgPaperCfg>();
}
