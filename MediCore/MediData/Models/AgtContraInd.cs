using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("AgtName", "AgtContraIndId")]
[Table("agt_contra_ind")]
public partial class AgtContraInd
{
    [Key]
    [Column("agt_name")]
    [StringLength(50)]
    public string AgtName { get; set; } = null!;

    [Key]
    [Column("agt_contra_ind_id")]
    public int AgtContraIndId { get; set; }

    [Column("agt_contra_ind_typ")]
    public int AgtContraIndTyp { get; set; }

    [Column("agt_contra_desc")]
    [StringLength(50)]
    public string? AgtContraDesc { get; set; }

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
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [ForeignKey("AgtContraIndTyp")]
    [InverseProperty("AgtContraInd")]
    public virtual AgtContraIndTyp AgtContraIndTypNavigation { get; set; } = null!;

    [ForeignKey("AgtName")]
    [InverseProperty("AgtContraInd")]
    public virtual AgtName AgtNameNavigation { get; set; } = null!;
}
