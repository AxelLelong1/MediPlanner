using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("base_typ")]
[Index("BaseClsTyp", Name = "nc1_base_typ")]
public partial class BaseTyp
{
    [Key]
    [Column("base_typ")]
    public int BaseTyp1 { get; set; }

    [Column("base_cls_typ")]
    public int BaseClsTyp { get; set; }

    [Column("base_desc")]
    [StringLength(40)]
    public string BaseDesc { get; set; } = null!;

    [Column("seq_no")]
    public int? SeqNo { get; set; }

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

    [InverseProperty("BaseTypNavigation")]
    public virtual ICollection<AdmnSite> AdmnSite { get; set; } = new List<AdmnSite>();

    [InverseProperty("BaseTypNavigation")]
    public virtual ICollection<BmiTrend> BmiTrend { get; set; } = new List<BmiTrend>();

    [InverseProperty("BaseTypNavigation")]
    public virtual ICollection<CompletionStatus> CompletionStatus { get; set; } = new List<CompletionStatus>();

    [InverseProperty("BaseTypNavigation")]
    public virtual ICollection<FinancialCls> FinancialCls { get; set; } = new List<FinancialCls>();

    [InverseProperty("BaseTypNavigation")]
    public virtual ICollection<ImmunRegStatus> ImmunRegStatus { get; set; } = new List<ImmunRegStatus>();

    [InverseProperty("BaseTypNavigation")]
    public virtual ICollection<Immunity> Immunity { get; set; } = new List<Immunity>();

    [InverseProperty("BaseTypNavigation")]
    public virtual ICollection<NokRelationship> NokRelationship { get; set; } = new List<NokRelationship>();

    [InverseProperty("ReconSourceTypNavigation")]
    public virtual ICollection<PtAllergyExternal> PtAllergyExternal { get; set; } = new List<PtAllergyExternal>();

    [InverseProperty("PtConsentTypNavigation")]
    public virtual ICollection<PtConsent> PtConsent { get; set; } = new List<PtConsent>();

    [InverseProperty("ReconSourceTypNavigation")]
    public virtual ICollection<PtDxExternal> PtDxExternal { get; set; } = new List<PtDxExternal>();

    [InverseProperty("DeliveryMethodActualTypNavigation")]
    public virtual ICollection<PtInfoRequest> PtInfoRequestDeliveryMethodActualTypNavigation { get; set; } = new List<PtInfoRequest>();

    [InverseProperty("DeliveryMethodRequestedTypNavigation")]
    public virtual ICollection<PtInfoRequest> PtInfoRequestDeliveryMethodRequestedTypNavigation { get; set; } = new List<PtInfoRequest>();

    [InverseProperty("PtPreferValueTypNavigation")]
    public virtual ICollection<PtPrefer> PtPrefer { get; set; } = new List<PtPrefer>();

    [InverseProperty("BaseTypNavigation")]
    public virtual ICollection<PublicityCd> PublicityCd { get; set; } = new List<PublicityCd>();

    [InverseProperty("BaseTypNavigation")]
    public virtual ICollection<RefusalReason> RefusalReason { get; set; } = new List<RefusalReason>();

    [InverseProperty("BaseTypNavigation")]
    public virtual ICollection<TelecomEquipCd> TelecomEquipCd { get; set; } = new List<TelecomEquipCd>();

    [InverseProperty("BaseTypNavigation")]
    public virtual ICollection<TelecomUseCd> TelecomUseCd { get; set; } = new List<TelecomUseCd>();
}
