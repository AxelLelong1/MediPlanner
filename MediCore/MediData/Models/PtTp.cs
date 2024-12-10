using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "DateTpInit")]
[Table("pt_tp")]
public partial class PtTp
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("date_tp_init", TypeName = "datetime")]
    public DateTime DateTpInit { get; set; }

    [Column("tp_name")]
    [StringLength(20)]
    public string? TpName { get; set; }

    [Column("tp_vers_no")]
    [StringLength(10)]
    public string? TpVersNo { get; set; }

    [Column("time_tp_init", TypeName = "datetime")]
    public DateTime TimeTpInit { get; set; }

    [Column("clinic_trial_flag")]
    [StringLength(1)]
    public string? ClinicTrialFlag { get; set; }

    [Column("date_tp_ended", TypeName = "datetime")]
    public DateTime? DateTpEnded { get; set; }

    [Column("rights_ack")]
    [StringLength(1)]
    public string? RightsAck { get; set; }

    [Column("organ_donor")]
    [StringLength(1)]
    public string? OrganDonor { get; set; }

    [Column("rls_of_info_date", TypeName = "datetime")]
    public DateTime? RlsOfInfoDate { get; set; }

    [Column("consent_date", TypeName = "datetime")]
    public DateTime? ConsentDate { get; set; }

    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Column("userid_link")]
    [StringLength(255)]
    public string UseridLink { get; set; } = null!;

    [Column("protocol_id")]
    [StringLength(20)]
    public string? ProtocolId { get; set; }

    [Column("consent_req")]
    [StringLength(1)]
    public string? ConsentReq { get; set; }

    [Column("pln_typ")]
    public int? PlnTyp { get; set; }

    [Column("site")]
    [StringLength(30)]
    public string? Site { get; set; }

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

    [Column("pt_study_no")]
    [StringLength(20)]
    public string? PtStudyNo { get; set; }

    [Column("dt_reg", TypeName = "datetime")]
    public DateTime? DtReg { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("pt_study_no_key_id")]
    public int? PtStudyNoKeyId { get; set; }

    [ForeignKey("PtId")]
    [InverseProperty("PtTp")]
    public virtual Pt Pt { get; set; } = null!;

    [InverseProperty("PtTp")]
    public virtual ICollection<PtTpIntv> PtTpIntv { get; set; } = new List<PtTpIntv>();

    [InverseProperty("PtTp")]
    public virtual ICollection<PtTpOrder> PtTpOrder { get; set; } = new List<PtTpOrder>();

    [InverseProperty("PtTp")]
    public virtual ICollection<PtTpPhase> PtTpPhase { get; set; } = new List<PtTpPhase>();

    [ForeignKey("InstId, UseridLink")]
    [InverseProperty("PtTp")]
    public virtual Userid Userid { get; set; } = null!;

    [InverseProperty("PtTp")]
    public virtual ICollection<XrefDxTp> XrefDxTp { get; set; } = new List<XrefDxTp>();
}
