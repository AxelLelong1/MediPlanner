using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("onco_regimen_typ")]
public partial class OncoRegimenTyp
{
    [Key]
    [Column("onco_regimen_typ_cd")]
    [StringLength(2)]
    public string OncoRegimenTypCd { get; set; } = null!;

    [Column("regimen_typ_desc")]
    [StringLength(25)]
    public string RegimenTypDesc { get; set; } = null!;

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

    [InverseProperty("OncoRegimenTypCdNavigation")]
    public virtual ICollection<OncoPtFsDet> OncoPtFsDet { get; set; } = new List<OncoPtFsDet>();
}
