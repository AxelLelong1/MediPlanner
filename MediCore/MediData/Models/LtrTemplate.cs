using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("ltr_template")]
public partial class LtrTemplate
{
    [Key]
    [Column("ltr_template_id")]
    public int LtrTemplateId { get; set; }

    [Column("ltr_vers_no")]
    [StringLength(10)]
    public string? LtrVersNo { get; set; }

    [Column("ltr_name")]
    [StringLength(60)]
    public string? LtrName { get; set; }

    [Column("ltr_typ")]
    public int? LtrTyp { get; set; }

    [Column("template_file")]
    [StringLength(255)]
    public string? TemplateFile { get; set; }

    [Column("template_location")]
    [StringLength(255)]
    public string? TemplateLocation { get; set; }

    [Column("cur_entry_ind")]
    [StringLength(1)]
    public string? CurEntryInd { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

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
