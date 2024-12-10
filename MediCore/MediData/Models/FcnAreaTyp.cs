using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("fcn_area_typ")]
public partial class FcnAreaTyp
{
    [Key]
    [Column("fcn_area_typ")]
    public int FcnAreaTyp1 { get; set; }

    [Column("fcn_area_typ_desc")]
    [StringLength(40)]
    public string FcnAreaTypDesc { get; set; } = null!;

    [Column("app_cd")]
    [StringLength(10)]
    public string AppCd { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [InverseProperty("FcnAreaTypNavigation")]
    public virtual ICollection<VrtnTyp> VrtnTyp { get; set; } = new List<VrtnTyp>();
}
