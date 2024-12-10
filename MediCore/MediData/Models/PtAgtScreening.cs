using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "AgtScreeningId")]
[Table("pt_agt_screening")]
public partial class PtAgtScreening
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("agt_screening_id")]
    public int AgtScreeningId { get; set; }

    [Column("pt_visit_id")]
    public int? PtVisitId { get; set; }

    [Column("rx_id")]
    public int? RxId { get; set; }

    [Column("user_inst_id")]
    [StringLength(30)]
    public string UserInstId { get; set; } = null!;

    [Column("userid")]
    [StringLength(255)]
    public string Userid { get; set; } = null!;

    [Column("screening_date", TypeName = "datetime")]
    public DateTime ScreeningDate { get; set; }

    [Column("num_interactions")]
    public int NumInteractions { get; set; }

    [Column("interactions_viewed_ind")]
    [StringLength(1)]
    public string InteractionsViewedInd { get; set; } = null!;

    [Column("num_contra")]
    public int NumContra { get; set; }

    [Column("contra_viewed_ind")]
    [StringLength(1)]
    public string ContraViewedInd { get; set; } = null!;

    [Column("num_allergies")]
    public int NumAllergies { get; set; }

    [Column("allergies_viewed_ind")]
    [StringLength(1)]
    public string AllergiesViewedInd { get; set; } = null!;

    [Column("screening_detail_ind")]
    [StringLength(1)]
    public string ScreeningDetailInd { get; set; } = null!;

    [Column("called_from")]
    [StringLength(10)]
    public string CalledFrom { get; set; } = null!;

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

    [Column("num_dosages")]
    public int? NumDosages { get; set; }

    [Column("dosages_viewed_ind")]
    [StringLength(1)]
    public string? DosagesViewedInd { get; set; }

    [Column("num_routes")]
    public int? NumRoutes { get; set; }

    [Column("routes_viewed_ind")]
    [StringLength(1)]
    public string? RoutesViewedInd { get; set; }

    [InverseProperty("PtAgtScreening")]
    public virtual PtAgtScreeningDetail? PtAgtScreeningDetail { get; set; }
}
