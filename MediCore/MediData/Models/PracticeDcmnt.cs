using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PracticeDcmntId", "InstId")]
[Table("practice_dcmnt")]
public partial class PracticeDcmnt
{
    [Key]
    [Column("practice_dcmnt_id")]
    public int PracticeDcmntId { get; set; }

    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Column("practice_dcmnt_name")]
    [StringLength(50)]
    public string PracticeDcmntName { get; set; } = null!;

    [Column("practice_dcmnt_typ")]
    public int PracticeDcmntTyp { get; set; }

    [Column("practice_dcmnt_txt")]
    public string? PracticeDcmntTxt { get; set; }

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

    [Column("file_ext")]
    [StringLength(10)]
    public string? FileExt { get; set; }
}
