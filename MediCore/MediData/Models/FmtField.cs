using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("fmt_field")]
public partial class FmtField
{
    [Key]
    [Column("fmt_field_id")]
    public int FmtFieldId { get; set; }

    [Column("country_id")]
    public int? CountryId { get; set; }

    [Column("fmt_cls_typ")]
    public int? FmtClsTyp { get; set; }

    [Column("fmt_field_name")]
    [StringLength(40)]
    public string? FmtFieldName { get; set; }

    [Column("fmt_field_list_name")]
    [StringLength(40)]
    public string? FmtFieldListName { get; set; }

    [Column("fmt_field_sort_order")]
    public int? FmtFieldSortOrder { get; set; }

    [Column("fmt_string_id")]
    public int FmtStringId { get; set; }

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

    [ForeignKey("CountryId, FmtFieldName")]
    [InverseProperty("FmtField")]
    public virtual CountryField? CountryField { get; set; }

    [InverseProperty("FacPcZipFmt")]
    public virtual ICollection<Fac> FacFacPcZipFmt { get; set; } = new List<Fac>();

    [InverseProperty("FacTelFmt")]
    public virtual ICollection<Fac> FacFacTelFmt { get; set; } = new List<Fac>();

    [InverseProperty("InsdPhoneFmt")]
    public virtual ICollection<FinancialIns> FinancialIns { get; set; } = new List<FinancialIns>();

    [ForeignKey("FmtClsTyp")]
    [InverseProperty("FmtField")]
    public virtual FmtClsTyp? FmtClsTypNavigation { get; set; }

    [ForeignKey("FmtStringId")]
    [InverseProperty("FmtField")]
    public virtual FmtString FmtString { get; set; } = null!;

    [InverseProperty("PcZipFmt")]
    public virtual ICollection<InsCoParent> InsCoParentPcZipFmt { get; set; } = new List<InsCoParent>();

    [InverseProperty("PhoneNoFmt")]
    public virtual ICollection<InsCoParent> InsCoParentPhoneNoFmt { get; set; } = new List<InsCoParent>();

    [InverseProperty("PcZipFmt")]
    public virtual ICollection<InsCo> InsCoPcZipFmt { get; set; } = new List<InsCo>();

    [InverseProperty("PhoneFmt")]
    public virtual ICollection<InsCo> InsCoPhoneFmt { get; set; } = new List<InsCo>();

    [InverseProperty("DeptTelFmt")]
    public virtual ICollection<InstDept> InstDept { get; set; } = new List<InstDept>();

    [InverseProperty("InstFaxFmt")]
    public virtual ICollection<Inst> InstInstFaxFmt { get; set; } = new List<Inst>();

    [InverseProperty("InstPcZipFmt")]
    public virtual ICollection<Inst> InstInstPcZipFmt { get; set; } = new List<Inst>();

    [InverseProperty("InstTelFmt")]
    public virtual ICollection<Inst> InstInstTelFmt { get; set; } = new List<Inst>();

    [InverseProperty("LocTelFmt")]
    public virtual ICollection<InstLoc> InstLoc { get; set; } = new List<InstLoc>();

    [InverseProperty("BusTelFmt")]
    public virtual ICollection<PtAddress> PtAddressBusTelFmt { get; set; } = new List<PtAddress>();

    [InverseProperty("FaxTelFmt")]
    public virtual ICollection<PtAddress> PtAddressFaxTelFmt { get; set; } = new List<PtAddress>();

    [InverseProperty("HomeTelFmt")]
    public virtual ICollection<PtAddress> PtAddressHomeTelFmt { get; set; } = new List<PtAddress>();

    [InverseProperty("MobileTelFmt")]
    public virtual ICollection<PtAddress> PtAddressMobileTelFmt { get; set; } = new List<PtAddress>();

    [InverseProperty("PcZipFmt")]
    public virtual ICollection<PtAddress> PtAddressPcZipFmt { get; set; } = new List<PtAddress>();

    [InverseProperty("BusTelFmt")]
    public virtual ICollection<PtContact> PtContactBusTelFmt { get; set; } = new List<PtContact>();

    [InverseProperty("HomeTelFmt")]
    public virtual ICollection<PtContact> PtContactHomeTelFmt { get; set; } = new List<PtContact>();

    [InverseProperty("PcZipFmt")]
    public virtual ICollection<PtContact> PtContactPcZipFmt { get; set; } = new List<PtContact>();

    [InverseProperty("BusTelFmt")]
    public virtual ICollection<PtGuar> PtGuarBusTelFmt { get; set; } = new List<PtGuar>();

    [InverseProperty("HomeTelFmt")]
    public virtual ICollection<PtGuar> PtGuarHomeTelFmt { get; set; } = new List<PtGuar>();

    [InverseProperty("PcZipFmt")]
    public virtual ICollection<PtGuar> PtGuarPcZipFmt { get; set; } = new List<PtGuar>();

    [InverseProperty("ContactTelFmt")]
    public virtual ICollection<PtInsPrecert> PtInsPrecert { get; set; } = new List<PtInsPrecert>();

    [InverseProperty("PcZipFmt")]
    public virtual ICollection<StkhAddress> StkhAddress { get; set; } = new List<StkhAddress>();

    [InverseProperty("PhoneNoFmt")]
    public virtual ICollection<StkhPhone> StkhPhone { get; set; } = new List<StkhPhone>();

    [InverseProperty("UserBusTelFmt")]
    public virtual ICollection<Userid> UseridUserBusTelFmt { get; set; } = new List<Userid>();

    [InverseProperty("UserHomeTelFmt")]
    public virtual ICollection<Userid> UseridUserHomeTelFmt { get; set; } = new List<Userid>();
}
