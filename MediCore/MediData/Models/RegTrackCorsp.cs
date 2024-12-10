using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("reg_track_corsp")]
public partial class RegTrackCorsp
{
    [Key]
    [Column("reg_track_corsp_id")]
    public int RegTrackCorspId { get; set; }

    [Column("reg_track_id")]
    public int RegTrackId { get; set; }

    [Column("cmtee_id")]
    public int CmteeId { get; set; }

    [Column("corsp_desc")]
    [StringLength(255)]
    public string? CorspDesc { get; set; }

    [Column("corsp_date", TypeName = "datetime")]
    public DateTime? CorspDate { get; set; }

    [Column("dcmnt_ind")]
    [StringLength(1)]
    public string? DcmntInd { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

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
}
