using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("country")]
public partial class Country
{
    [Key]
    [Column("country_id")]
    public int CountryId { get; set; }

    [Column("country_desc")]
    [StringLength(44)]
    public string CountryDesc { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("sin_fmt")]
    [StringLength(20)]
    public string? SinFmt { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("phys_reg_label")]
    [StringLength(20)]
    public string? PhysRegLabel { get; set; }

    [Column("phys_rx_label")]
    [StringLength(20)]
    public string? PhysRxLabel { get; set; }

    [Column("phys_reg_label_fmt")]
    [StringLength(15)]
    public string? PhysRegLabelFmt { get; set; }

    [Column("phys_rx_label_fmt")]
    [StringLength(15)]
    public string? PhysRxLabelFmt { get; set; }

    [Column("country_cd")]
    [StringLength(3)]
    public string? CountryCd { get; set; }

    [InverseProperty("Country")]
    public virtual ICollection<Fac> Fac { get; set; } = new List<Fac>();

    [InverseProperty("Country")]
    public virtual ICollection<InsCoParent> InsCoParent { get; set; } = new List<InsCoParent>();

    [InverseProperty("Country")]
    public virtual ICollection<PrvState> PrvState { get; set; } = new List<PrvState>();

    [InverseProperty("Citizenship")]
    public virtual ICollection<Pt> Pt { get; set; } = new List<Pt>();

    [InverseProperty("Country")]
    public virtual ICollection<PtAddress> PtAddress { get; set; } = new List<PtAddress>();

    [InverseProperty("Country")]
    public virtual ICollection<PtContact> PtContact { get; set; } = new List<PtContact>();
}
