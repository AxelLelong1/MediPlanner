using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("BillEmCatTyp", "BillEmElmtTyp", "BillEmMinCount")]
[Table("bill_em_defn")]
public partial class BillEmDefn
{
    [Key]
    [Column("bill_em_cat_typ")]
    public int BillEmCatTyp { get; set; }

    [Key]
    [Column("bill_em_elmt_typ")]
    public int BillEmElmtTyp { get; set; }

    [Key]
    [Column("bill_em_min_count")]
    public int BillEmMinCount { get; set; }

    [Column("bill_em_level")]
    public int BillEmLevel { get; set; }

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

    [ForeignKey("BillEmCatTyp")]
    [InverseProperty("BillEmDefn")]
    public virtual BillEmCatTyp BillEmCatTypNavigation { get; set; } = null!;

    [ForeignKey("BillEmElmtTyp")]
    [InverseProperty("BillEmDefn")]
    public virtual BillEmElmtTyp BillEmElmtTypNavigation { get; set; } = null!;
}
