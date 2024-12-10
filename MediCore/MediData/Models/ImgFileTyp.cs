using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("img_file_typ")]
public partial class ImgFileTyp
{
    [Key]
    [Column("file_typ")]
    public int FileTyp { get; set; }

    [Column("file_desc")]
    [StringLength(255)]
    public string FileDesc { get; set; } = null!;

    [Column("file_ext")]
    [StringLength(4)]
    public string FileExt { get; set; } = null!;

    [Column("show_user_ind")]
    [StringLength(1)]
    public string ShowUserInd { get; set; } = null!;

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

    [InverseProperty("FileTypNavigation")]
    public virtual ICollection<ImgScanMode> ImgScanMode { get; set; } = new List<ImgScanMode>();
}
