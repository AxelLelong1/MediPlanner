using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("next_of_kin")]
public partial class NextOfKin
{
    [Key]
    [Column("nok_reltn")]
    public int NokReltn { get; set; }

    [Column("reltn_desc")]
    [StringLength(40)]
    public string ReltnDesc { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("fam_mbr_ind")]
    [StringLength(1)]
    public string? FamMbrInd { get; set; }

    [Column("reltn_pos")]
    public int? ReltnPos { get; set; }

    [Column("reltn_cd")]
    [StringLength(18)]
    public string? ReltnCd { get; set; }

    [InverseProperty("ReltnTypNavigation")]
    public virtual ICollection<PtContact> PtContact { get; set; } = new List<PtContact>();
}
