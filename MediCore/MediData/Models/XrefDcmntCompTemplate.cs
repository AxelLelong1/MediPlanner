using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("XrefDcmntCompTemplateId", "InstId")]
[Table("xref_dcmnt_comp_template")]
public partial class XrefDcmntCompTemplate
{
    [Key]
    [Column("xref_dcmnt_comp_template_id")]
    public int XrefDcmntCompTemplateId { get; set; }

    [Column("dcmnt_template_id")]
    public int DcmntTemplateId { get; set; }

    [Column("comp_template_id")]
    public int CompTemplateId { get; set; }

    [Key]
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

    [ForeignKey("InstId, CompTemplateId")]
    [InverseProperty("XrefDcmntCompTemplatePnTemplate")]
    public virtual PnTemplate PnTemplate { get; set; } = null!;

    [ForeignKey("InstId, DcmntTemplateId")]
    [InverseProperty("XrefDcmntCompTemplatePnTemplateNavigation")]
    public virtual PnTemplate PnTemplateNavigation { get; set; } = null!;
}
