using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "TemplateId")]
[Table("pn_template")]
public partial class PnTemplate
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("template_id")]
    public int TemplateId { get; set; }

    [Column("template_typ")]
    public int TemplateTyp { get; set; }

    [Column("template_name")]
    [StringLength(50)]
    public string TemplateName { get; set; } = null!;

    [Column("template_txt")]
    public string TemplateTxt { get; set; } = null!;

    [Column("author_inst_id")]
    [StringLength(30)]
    public string? AuthorInstId { get; set; }

    [Column("author_userid")]
    [StringLength(255)]
    public string? AuthorUserid { get; set; }

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

    [Column("personal_template_ind")]
    [StringLength(1)]
    public string? PersonalTemplateInd { get; set; }

    [Column("template_use_cd")]
    [StringLength(2)]
    public string? TemplateUseCd { get; set; }

    [Column("comp_id")]
    [StringLength(10)]
    public string? CompId { get; set; }

    [Column("base_tbl_ind")]
    [StringLength(1)]
    public string? BaseTblInd { get; set; }

    [Column("app_cd")]
    [StringLength(10)]
    public string? AppCd { get; set; }

    [Column("file_path")]
    [StringLength(255)]
    public string? FilePath { get; set; }

    [Column("revision_no")]
    public int? RevisionNo { get; set; }

    [Column("default_ct_ind")]
    [StringLength(1)]
    public string? DefaultCtInd { get; set; }

    [InverseProperty("PnTemplate")]
    public virtual ICollection<AgtFormulary> AgtFormulary { get; set; } = new List<AgtFormulary>();

    [InverseProperty("PnTemplate")]
    public virtual ICollection<AgtGrp> AgtGrp { get; set; } = new List<AgtGrp>();

    [InverseProperty("PnTemplate")]
    public virtual ICollection<VisitReasonPnTemplate> VisitReasonPnTemplate { get; set; } = new List<VisitReasonPnTemplate>();

    [InverseProperty("PnTemplate")]
    public virtual ICollection<XrefDcmntCompTemplate> XrefDcmntCompTemplatePnTemplate { get; set; } = new List<XrefDcmntCompTemplate>();

    [InverseProperty("PnTemplateNavigation")]
    public virtual ICollection<XrefDcmntCompTemplate> XrefDcmntCompTemplatePnTemplateNavigation { get; set; } = new List<XrefDcmntCompTemplate>();
}
