using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("agt_formulary_disp_loc_map")]
public partial class AgtFormularyDispLocMap
{
    [Key]
    [Column("agt_formulary_disp_loc_map_id")]
    public int AgtFormularyDispLocMapId { get; set; }

    [Column("agt_formulary_disp_loc_id")]
    [StringLength(20)]
    public string AgtFormularyDispLocId { get; set; } = null!;

    [Column("mapping_typ")]
    [StringLength(2)]
    public string MappingTyp { get; set; } = null!;

    [Column("mapping_cd")]
    [StringLength(30)]
    public string MappingCd { get; set; } = null!;

    [Column("eff_date", TypeName = "datetime")]
    public DateTime EffDate { get; set; }

    [Column("term_date", TypeName = "datetime")]
    public DateTime? TermDate { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string TransLogMuserid { get; set; } = null!;

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string TransLogMinstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [ForeignKey("AgtFormularyDispLocId")]
    [InverseProperty("AgtFormularyDispLocMap")]
    public virtual XrefAgtFormularyDispLoc AgtFormularyDispLoc { get; set; } = null!;
}
