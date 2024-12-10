using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("TypOfTest", "CompName", "BillEmCptTyp")]
[Table("xref_test_comp_cpt")]
public partial class XrefTestCompCpt
{
    [Key]
    [Column("typ_of_test")]
    [StringLength(20)]
    public string TypOfTest { get; set; } = null!;

    [Key]
    [Column("comp_name")]
    [StringLength(30)]
    public string CompName { get; set; } = null!;

    [Key]
    [Column("bill_em_cpt_typ")]
    public int BillEmCptTyp { get; set; }

    [Column("bill_em_cpt_count")]
    public int BillEmCptCount { get; set; }

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

    [ForeignKey("BillEmCptTyp")]
    [InverseProperty("XrefTestCompCpt")]
    public virtual BillEmCptTyp BillEmCptTypNavigation { get; set; } = null!;

    [ForeignKey("TypOfTest, CompName")]
    [InverseProperty("XrefTestCompCpt")]
    public virtual TestComp TestComp { get; set; } = null!;
}
