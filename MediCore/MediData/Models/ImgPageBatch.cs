using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("img_page_batch")]
public partial class ImgPageBatch
{
    [Key]
    [Column("img_batch_id")]
    [StringLength(14)]
    public string ImgBatchId { get; set; } = null!;

    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Column("no_pages")]
    public int? NoPages { get; set; }

    [Column("note_txt")]
    public string? NoteTxt { get; set; }

    [Column("dir_name")]
    [StringLength(255)]
    public string? DirName { get; set; }

    [Column("file_name")]
    [StringLength(255)]
    public string? FileName { get; set; }

    [Column("first_in_batch")]
    [StringLength(10)]
    public string? FirstInBatch { get; set; }

    [Column("master_batch_id")]
    [StringLength(14)]
    public string? MasterBatchId { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("page_no")]
    public int? PageNo { get; set; }

    [Column("img_res")]
    public int? ImgRes { get; set; }

    [Column("compress_factor")]
    public int? CompressFactor { get; set; }
}
