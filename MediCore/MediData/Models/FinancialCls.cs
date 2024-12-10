using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("financial_cls")]
public partial class FinancialCls
{
    [Key]
    [Column("financial_cls_id")]
    public int FinancialClsId { get; set; }

    [Column("base_typ")]
    public int BaseTyp { get; set; }

    [Column("financial_cls_desc")]
    [StringLength(72)]
    public string? FinancialClsDesc { get; set; }

    [Column("hl7_financial_cls")]
    [StringLength(3)]
    public string? Hl7FinancialCls { get; set; }

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

    [ForeignKey("BaseTyp")]
    [InverseProperty("FinancialCls")]
    public virtual BaseTyp BaseTypNavigation { get; set; } = null!;
}
