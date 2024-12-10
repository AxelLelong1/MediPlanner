using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("iv_fluid")]
public partial class IvFluid
{
    [Column("iv_fluid_name")]
    [StringLength(60)]
    public string IvFluidName { get; set; } = null!;

    [Column("iv_fluid_cd")]
    [StringLength(10)]
    public string IvFluidCd { get; set; } = null!;

    [Key]
    [Column("gnrc_iv_fluid_name")]
    [StringLength(60)]
    public string GnrcIvFluidName { get; set; } = null!;

    [Column("display_seq")]
    public int? DisplaySeq { get; set; }

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

    [InverseProperty("GnrcIvFluidNameNavigation")]
    public virtual ICollection<TpIvTherapy> TpIvTherapy { get; set; } = new List<TpIvTherapy>();
}
