using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("FbmPgmId", "FbmPgmSchId")]
[Table("fbm_pgm_sch")]
public partial class FbmPgmSch
{
    [Key]
    [Column("fbm_pgm_id")]
    public int FbmPgmId { get; set; }

    [Key]
    [Column("fbm_pgm_sch_id")]
    public int FbmPgmSchId { get; set; }

    [Column("fbm_pgm_sch_month")]
    public int FbmPgmSchMonth { get; set; }

    [Column("fbm_ltr_id")]
    public int FbmLtrId { get; set; }

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
}
