using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("TrSubCompId", "CultureCd")]
[Table("gs_tr_sub_comp_culture")]
public partial class GsTrSubCompCulture
{
    [Key]
    [Column("tr_sub_comp_id")]
    public int TrSubCompId { get; set; }

    [Key]
    [Column("culture_cd")]
    [StringLength(10)]
    public string CultureCd { get; set; } = null!;

    [Column("tr_typ")]
    [StringLength(30)]
    public string TrTyp { get; set; } = null!;

    [Column("tr_comp_name")]
    [StringLength(100)]
    public string TrCompName { get; set; } = null!;

    [Column("tr_sub_comp_group")]
    [StringLength(100)]
    public string? TrSubCompGroup { get; set; }

    [Column("tr_sub_comp_name")]
    [StringLength(100)]
    public string? TrSubCompName { get; set; }

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
