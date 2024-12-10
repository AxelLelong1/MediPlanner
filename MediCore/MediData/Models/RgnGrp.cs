using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("rgn_grp")]
public partial class RgnGrp
{
    [Key]
    [Column("rgn_grp_id")]
    public int RgnGrpId { get; set; }

    [Column("rgn_grp_cat_typ")]
    public int RgnGrpCatTyp { get; set; }

    [Column("rgn_desc")]
    [StringLength(50)]
    public string RgnDesc { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
