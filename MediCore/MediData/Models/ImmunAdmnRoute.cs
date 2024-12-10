using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("immun_admn_route")]
public partial class ImmunAdmnRoute
{
    [Key]
    [Column("immun_admn_route_id")]
    public int ImmunAdmnRouteId { get; set; }

    [Column("admn_route_id")]
    public int AdmnRouteId { get; set; }

    [Column("admn_route_desc")]
    [StringLength(85)]
    public string? AdmnRouteDesc { get; set; }

    [Column("fda_immun_admn_route")]
    [StringLength(6)]
    public string? FdaImmunAdmnRoute { get; set; }

    [Column("hl7_immun_admn_route")]
    [StringLength(3)]
    public string? Hl7ImmunAdmnRoute { get; set; }

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

    [ForeignKey("AdmnRouteId")]
    [InverseProperty("ImmunAdmnRoute")]
    public virtual AdmnRoute AdmnRoute { get; set; } = null!;
}
