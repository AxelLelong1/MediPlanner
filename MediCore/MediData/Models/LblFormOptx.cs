using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("lbl_form_optx")]
public partial class LblFormOptx
{
    [Key]
    [Column("optx_lbl_id")]
    [StringLength(20)]
    public string OptxLblId { get; set; } = null!;

    [Column("optx_lbl_desc")]
    [StringLength(60)]
    public string OptxLblDesc { get; set; } = null!;

    [Column("inst_ind")]
    [StringLength(1)]
    public string InstInd { get; set; } = null!;

    [Column("fac_ind")]
    [StringLength(1)]
    public string FacInd { get; set; } = null!;

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

    [InverseProperty("OptxLbl")]
    public virtual ICollection<LblFormInst> LblFormInst { get; set; } = new List<LblFormInst>();

    [InverseProperty("OptxLbl")]
    public virtual ICollection<LblFormTbl> LblFormTbl { get; set; } = new List<LblFormTbl>();
}
