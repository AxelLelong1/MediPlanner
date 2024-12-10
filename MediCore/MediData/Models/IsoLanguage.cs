using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("iso_language")]
[Index("Lang2Cd", "Lang3Cd", "LangDesc", Name = "nc1_iso_language", IsUnique = true)]
public partial class IsoLanguage
{
    [Key]
    [Column("iso_lang_id")]
    public int IsoLangId { get; set; }

    [Column("lang_2_cd")]
    [StringLength(2)]
    public string? Lang2Cd { get; set; }

    [Column("lang_3_cd")]
    [StringLength(3)]
    public string? Lang3Cd { get; set; }

    [Column("lang_desc")]
    [StringLength(64)]
    public string LangDesc { get; set; } = null!;

    [Column("active_ind")]
    [StringLength(1)]
    public string? ActiveInd { get; set; }

    [Column("default_ind")]
    [StringLength(1)]
    public string? DefaultInd { get; set; }

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
