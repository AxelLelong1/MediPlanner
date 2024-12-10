using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("lbl_form")]
public partial class LblForm
{
    [Key]
    [Column("lbl_form_id")]
    [StringLength(20)]
    public string LblFormId { get; set; } = null!;

    [Column("lbl_form_desc")]
    [StringLength(60)]
    public string LblFormDesc { get; set; } = null!;

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

    [Column("optx_lbl_tbl_id")]
    [StringLength(30)]
    public string? OptxLblTblId { get; set; }

    [InverseProperty("LblForm")]
    public virtual ICollection<LblFormDet> LblFormDet { get; set; } = new List<LblFormDet>();

    [InverseProperty("LblForm")]
    public virtual ICollection<LblFormInst> LblFormInst { get; set; } = new List<LblFormInst>();
}
