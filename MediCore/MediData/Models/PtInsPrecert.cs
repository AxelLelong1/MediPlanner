using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "FinancialInsId", "InsPrecertId")]
[Table("pt_ins_precert")]
public partial class PtInsPrecert
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("financial_ins_id")]
    public int FinancialInsId { get; set; }

    [Key]
    [Column("ins_precert_id")]
    public int InsPrecertId { get; set; }

    [Column("precert_no")]
    [StringLength(20)]
    public string? PrecertNo { get; set; }

    [Column("status_ind")]
    [StringLength(1)]
    public string? StatusInd { get; set; }

    [Column("contact_first_name")]
    [StringLength(30)]
    public string? ContactFirstName { get; set; }

    [Column("contact_last_name")]
    [StringLength(30)]
    public string? ContactLastName { get; set; }

    [Column("contact_tel")]
    [StringLength(28)]
    public string? ContactTel { get; set; }

    [Column("contact_tel_ext")]
    [StringLength(10)]
    public string? ContactTelExt { get; set; }

    [Column("contact_fax")]
    [StringLength(28)]
    public string? ContactFax { get; set; }

    [Column("precert_cmt")]
    public string? PrecertCmt { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("start_tstamp", TypeName = "datetime")]
    public DateTime? StartTstamp { get; set; }

    [Column("end_tstamp", TypeName = "datetime")]
    public DateTime? EndTstamp { get; set; }

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

    [Column("contact_tel_fmt_id")]
    public int? ContactTelFmtId { get; set; }

    [Column("active_entry_ind")]
    [StringLength(1)]
    public string? ActiveEntryInd { get; set; }

    [Column("contact_fax_fmt_id")]
    public int? ContactFaxFmtId { get; set; }

    [ForeignKey("ContactTelFmtId")]
    [InverseProperty("PtInsPrecert")]
    public virtual FmtField? ContactTelFmt { get; set; }

    [ForeignKey("PtId, FinancialInsId")]
    [InverseProperty("PtInsPrecert")]
    public virtual FinancialIns FinancialIns { get; set; } = null!;

    [InverseProperty("PtInsPrecert")]
    public virtual ICollection<PtInsPrecertDet> PtInsPrecertDet { get; set; } = new List<PtInsPrecertDet>();
}
