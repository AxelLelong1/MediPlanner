﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("img_dcmnt")]
public partial class ImgDcmnt
{
    [Key]
    [Column("img_dcmnt_id")]
    [StringLength(14)]
    public string ImgDcmntId { get; set; } = null!;

    [Column("dcmnt_desc")]
    [StringLength(255)]
    public string? DcmntDesc { get; set; }

    [Column("cur_vers_no")]
    public int CurVersNo { get; set; }

    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

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

    [Column("del_ind")]
    [StringLength(1)]
    public string? DelInd { get; set; }

    [InverseProperty("ImgDcmnt")]
    public virtual ICollection<ImgPage> ImgPage { get; set; } = new List<ImgPage>();
}
