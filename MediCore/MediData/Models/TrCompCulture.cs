using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("TrCompId", "CultureCd")]
[Table("tr_comp_culture")]
public partial class TrCompCulture
{
    [Key]
    [Column("tr_comp_id")]
    public int TrCompId { get; set; }

    [Key]
    [Column("culture_cd")]
    [StringLength(10)]
    public string CultureCd { get; set; } = null!;

    [Column("tr_typ")]
    [StringLength(100)]
    public string TrTyp { get; set; } = null!;

    [Column("tr_comp_name")]
    [StringLength(100)]
    public string TrCompName { get; set; } = null!;

    [Column("gnrc_tr_typ")]
    [StringLength(100)]
    public string GnrcTrTyp { get; set; } = null!;

    [Column("gnrc_tr_comp_name")]
    [StringLength(100)]
    public string GnrcTrCompName { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
