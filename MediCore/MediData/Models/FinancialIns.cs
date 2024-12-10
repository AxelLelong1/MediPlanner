using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "FinancialInsId")]
[Table("financial_ins")]
[Index("ActiveEntryInd", "ValidEntryInd", "CopayAmt", "PtId", Name = "nc1_financial_ins")]
public partial class FinancialIns
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("financial_ins_id")]
    public int FinancialInsId { get; set; }

    [Column("ins_co_id")]
    public int? InsCoId { get; set; }

    [Column("policy_no")]
    [StringLength(30)]
    public string? PolicyNo { get; set; }

    [Column("certificate_no")]
    [StringLength(30)]
    public string? CertificateNo { get; set; }

    [Column("ins_group_no")]
    [StringLength(30)]
    public string? InsGroupNo { get; set; }

    [Column("hmo_auth_no")]
    [StringLength(30)]
    public string? HmoAuthNo { get; set; }

    [Column("policy_holder")]
    [StringLength(30)]
    public string? PolicyHolder { get; set; }

    [Column("reltn_to_insd")]
    public int? ReltnToInsd { get; set; }

    [Column("insd_last_name")]
    [StringLength(30)]
    public string? InsdLastName { get; set; }

    [Column("insd_first_name")]
    [StringLength(30)]
    public string? InsdFirstName { get; set; }

    [Column("insd_initial")]
    [StringLength(2)]
    public string? InsdInitial { get; set; }

    [Column("insd_dob", TypeName = "datetime")]
    public DateTime? InsdDob { get; set; }

    [Column("insd_sin_ssn")]
    [StringLength(10)]
    public string? InsdSinSsn { get; set; }

    [Column("insd_address_1")]
    [StringLength(30)]
    public string? InsdAddress1 { get; set; }

    [Column("insd_address_2")]
    [StringLength(30)]
    public string? InsdAddress2 { get; set; }

    [Column("insd_address_3")]
    [StringLength(30)]
    public string? InsdAddress3 { get; set; }

    [Column("insd_city")]
    [StringLength(30)]
    public string? InsdCity { get; set; }

    [Column("insd_prv_state")]
    [StringLength(30)]
    public string? InsdPrvState { get; set; }

    [Column("insd_pc_zip")]
    [StringLength(10)]
    public string? InsdPcZip { get; set; }

    [Column("insd_country_id")]
    public int? InsdCountryId { get; set; }

    [Column("insd_phone")]
    [StringLength(28)]
    public string? InsdPhone { get; set; }

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

    [Column("primary_ind")]
    [StringLength(1)]
    public string? PrimaryInd { get; set; }

    [Column("ins_co_grp_id")]
    public int? InsCoGrpId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("plcy_typ_id")]
    public int? PlcyTypId { get; set; }

    [Column("hmo_ind")]
    [StringLength(1)]
    public string? HmoInd { get; set; }

    [Column("inst_id")]
    [StringLength(30)]
    public string? InstId { get; set; }

    [Column("inactive_tstamp", TypeName = "datetime")]
    public DateTime? InactiveTstamp { get; set; }

    [Column("current_entry_ind")]
    [StringLength(1)]
    public string? CurrentEntryInd { get; set; }

    [Column("active_entry_ind")]
    [StringLength(1)]
    public string? ActiveEntryInd { get; set; }

    [Column("insd_prv_state_id")]
    public int? InsdPrvStateId { get; set; }

    [Column("active_date", TypeName = "datetime")]
    public DateTime? ActiveDate { get; set; }

    [Column("active_date_cd")]
    public int? ActiveDateCd { get; set; }

    [Column("copay_amt", TypeName = "numeric(8, 2)")]
    public decimal? CopayAmt { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("same_addr_ind")]
    [StringLength(1)]
    public string? SameAddrInd { get; set; }

    [Column("county")]
    [StringLength(30)]
    public string? County { get; set; }

    [Column("prv_state_id")]
    public int? PrvStateId { get; set; }

    [Column("insd_pc_zip_fmt_id")]
    public int? InsdPcZipFmtId { get; set; }

    [Column("insd_phone_fmt_id")]
    public int? InsdPhoneFmtId { get; set; }

    [Column("insd_id_no")]
    [StringLength(33)]
    public string? InsdIdNo { get; set; }

    [Column("intf_ins_co_id")]
    public int? IntfInsCoId { get; set; }

    [Column("precert_req_ind")]
    [StringLength(1)]
    public string? PrecertReqInd { get; set; }

    [Column("insd_sex_cd")]
    [StringLength(1)]
    public string? InsdSexCd { get; set; }

    [ForeignKey("InstId, InsCoId")]
    [InverseProperty("FinancialIns")]
    public virtual InsCo? InsCo { get; set; }

    [ForeignKey("InsdPhoneFmtId")]
    [InverseProperty("FinancialIns")]
    public virtual FmtField? InsdPhoneFmt { get; set; }

    [ForeignKey("PlcyTypId")]
    [InverseProperty("FinancialIns")]
    public virtual PlcyTyp? PlcyTyp { get; set; }

    [InverseProperty("FinancialIns")]
    public virtual ICollection<PtInsPrecert> PtInsPrecert { get; set; } = new List<PtInsPrecert>();
}
