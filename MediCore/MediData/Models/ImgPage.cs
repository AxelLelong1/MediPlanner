using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("img_page")]
[Index("ImgDcmntId", Name = "nc1_img_page")]
public partial class ImgPage
{
    [Key]
    [Column("img_id")]
    [StringLength(14)]
    public string ImgId { get; set; } = null!;

    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Column("img_dcmnt_id")]
    [StringLength(14)]
    public string? ImgDcmntId { get; set; }

    [Column("page_no")]
    public int? PageNo { get; set; }

    [Column("vers_no")]
    public int? VersNo { get; set; }

    [Column("dir_name")]
    [StringLength(255)]
    public string? DirName { get; set; }

    [Column("file_name")]
    [StringLength(255)]
    public string? FileName { get; set; }

    [Column("annotation_ind")]
    [StringLength(1)]
    public string? AnnotationInd { get; set; }

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

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("img_res")]
    public int? ImgRes { get; set; }

    [Column("compress_factor")]
    public int? CompressFactor { get; set; }

    [ForeignKey("ImgDcmntId")]
    [InverseProperty("ImgPage")]
    public virtual ImgDcmnt? ImgDcmnt { get; set; }
}
