using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("prv_state")]
public partial class PrvState
{
    [Key]
    [Column("prv_state_id")]
    public int PrvStateId { get; set; }

    [Column("prv_state")]
    [StringLength(30)]
    public string PrvState1 { get; set; } = null!;

    [Column("prv_state_abrv")]
    [StringLength(4)]
    public string PrvStateAbrv { get; set; } = null!;

    [Column("country_id")]
    public int CountryId { get; set; }

    [Column("pc_zip_lower")]
    [StringLength(10)]
    public string? PcZipLower { get; set; }

    [Column("pc_zip_upper")]
    [StringLength(10)]
    public string? PcZipUpper { get; set; }

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

    [ForeignKey("CountryId")]
    [InverseProperty("PrvState")]
    public virtual Country Country { get; set; } = null!;

    [InverseProperty("PrvStateNavigation")]
    public virtual ICollection<InsCo> InsCo { get; set; } = new List<InsCo>();

    [InverseProperty("PrvStateNavigation")]
    public virtual ICollection<InsCoParent> InsCoParent { get; set; } = new List<InsCoParent>();

    [InverseProperty("PrvState")]
    public virtual ICollection<Inst> Inst { get; set; } = new List<Inst>();

    [InverseProperty("PrvStateNavigation")]
    public virtual ICollection<PtAddress> PtAddress { get; set; } = new List<PtAddress>();
}
