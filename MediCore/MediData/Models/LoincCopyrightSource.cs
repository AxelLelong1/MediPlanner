using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("loinc_copyright_source")]
public partial class LoincCopyrightSource
{
    [Key]
    [Column("copyright_id")]
    [StringLength(255)]
    public string CopyrightId { get; set; } = null!;

    [Column("name")]
    [StringLength(255)]
    public string Name { get; set; } = null!;

    [Column("copyright")]
    public string? Copyright { get; set; }

    [Column("terms_of_use")]
    public string? TermsOfUse { get; set; }

    [Column("url")]
    [StringLength(255)]
    public string? Url { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime TransLogMtstamp { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string TransLogMuserid { get; set; } = null!;

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string TransLogMinstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
