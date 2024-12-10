using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("disp_loc")]
public partial class DispLoc
{
    [Key]
    [Column("disp_loc_id")]
    public int DispLocId { get; set; }

    [Column("disp_loc_typ")]
    public int DispLocTyp { get; set; }

    [Column("disp_loc_name")]
    [StringLength(50)]
    public string DispLocName { get; set; } = null!;

    [Column("next_dose_lead_time")]
    public int? NextDoseLeadTime { get; set; }

    [Column("active_entry_ind")]
    [StringLength(1)]
    public string? ActiveEntryInd { get; set; }

    [Column("elctrnc_trf_ind")]
    [StringLength(1)]
    public string? ElctrncTrfInd { get; set; }

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

    [Column("disp_loc_open_time")]
    [StringLength(4)]
    public string? DispLocOpenTime { get; set; }

    [Column("disp_loc_close_time")]
    [StringLength(4)]
    public string? DispLocCloseTime { get; set; }

    [Column("adjust_drug_batch_expiry_ind")]
    [StringLength(1)]
    public string? AdjustDrugBatchExpiryInd { get; set; }

    [InverseProperty("DispLoc")]
    public virtual ICollection<AgtRx> AgtRx { get; set; } = new List<AgtRx>();

    [InverseProperty("DispLoc")]
    public virtual ICollection<AgtRxPharm> AgtRxPharm { get; set; } = new List<AgtRxPharm>();

    [ForeignKey("DispLocTyp")]
    [InverseProperty("DispLoc")]
    public virtual DispLocTyp DispLocTypNavigation { get; set; } = null!;

    [InverseProperty("DispLoc")]
    public virtual ICollection<ProductDispLocXref> ProductDispLocXref { get; set; } = new List<ProductDispLocXref>();

    [InverseProperty("DispLoc")]
    public virtual ICollection<StorageLoc> StorageLoc { get; set; } = new List<StorageLoc>();

    [InverseProperty("DispLoc")]
    public virtual ICollection<TherapyItemAdmn> TherapyItemAdmn { get; set; } = new List<TherapyItemAdmn>();

    [InverseProperty("DispLoc")]
    public virtual ICollection<XrefAgtFormularyDispLoc> XrefAgtFormularyDispLoc { get; set; } = new List<XrefAgtFormularyDispLoc>();

    [InverseProperty("DispLoc")]
    public virtual ICollection<XrefInstDispLoc> XrefInstDispLoc { get; set; } = new List<XrefInstDispLoc>();

    [InverseProperty("DispLoc")]
    public virtual ICollection<XrefInstLocDispLoc> XrefInstLocDispLoc { get; set; } = new List<XrefInstLocDispLoc>();
}
