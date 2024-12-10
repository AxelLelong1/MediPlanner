using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("GuarId", "PtId")]
[Table("pt_guar")]
public partial class PtGuar
{
    [Key]
    [Column("guar_id")]
    [StringLength(20)]
    public string GuarId { get; set; } = null!;

    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Column("guar_last_name")]
    [StringLength(30)]
    public string? GuarLastName { get; set; }

    [Column("guar_first_name")]
    [StringLength(30)]
    public string? GuarFirstName { get; set; }

    [Column("guar_initial")]
    [StringLength(1)]
    public string? GuarInitial { get; set; }

    [Column("guar_org_name")]
    [StringLength(40)]
    public string? GuarOrgName { get; set; }

    [Column("address_1")]
    [StringLength(30)]
    public string? Address1 { get; set; }

    [Column("address_2")]
    [StringLength(30)]
    public string? Address2 { get; set; }

    [Column("address_3")]
    [StringLength(30)]
    public string? Address3 { get; set; }

    [Column("city")]
    [StringLength(30)]
    public string? City { get; set; }

    [Column("prv_state_id")]
    public int? PrvStateId { get; set; }

    [Column("pc_zip")]
    [StringLength(10)]
    public string? PcZip { get; set; }

    [Column("country_id")]
    public int? CountryId { get; set; }

    [Column("home_tel")]
    [StringLength(28)]
    public string? HomeTel { get; set; }

    [Column("bus_tel")]
    [StringLength(28)]
    public string? BusTel { get; set; }

    [Column("bus_tel_ext")]
    [StringLength(10)]
    public string? BusTelExt { get; set; }

    [Column("guar_typ")]
    [StringLength(1)]
    public string? GuarTyp { get; set; }

    [Column("guar_reltn")]
    public int? GuarReltn { get; set; }

    [Column("current_ind")]
    [StringLength(1)]
    public string? CurrentInd { get; set; }

    [Column("guar_eff_date", TypeName = "datetime")]
    public DateTime? GuarEffDate { get; set; }

    [Column("guar_term_date", TypeName = "datetime")]
    public DateTime? GuarTermDate { get; set; }

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

    [Column("guar_sin_ssn")]
    [StringLength(20)]
    public string? GuarSinSsn { get; set; }

    [Column("guar_dob", TypeName = "datetime")]
    public DateTime? GuarDob { get; set; }

    [Column("guar_sex_cd")]
    [StringLength(1)]
    public string? GuarSexCd { get; set; }

    [Column("guar_emp_status_typ")]
    public int? GuarEmpStatusTyp { get; set; }

    [Column("same_addr_ind")]
    [StringLength(1)]
    public string? SameAddrInd { get; set; }

    [Column("county")]
    [StringLength(30)]
    public string? County { get; set; }

    [Column("prv_state")]
    [StringLength(30)]
    public string? PrvState { get; set; }

    [Column("pc_zip_fmt_id")]
    public int? PcZipFmtId { get; set; }

    [Column("bus_tel_fmt_id")]
    public int? BusTelFmtId { get; set; }

    [Column("home_tel_fmt_id")]
    public int? HomeTelFmtId { get; set; }

    [ForeignKey("BusTelFmtId")]
    [InverseProperty("PtGuarBusTelFmt")]
    public virtual FmtField? BusTelFmt { get; set; }

    [ForeignKey("HomeTelFmtId")]
    [InverseProperty("PtGuarHomeTelFmt")]
    public virtual FmtField? HomeTelFmt { get; set; }

    [ForeignKey("PcZipFmtId")]
    [InverseProperty("PtGuarPcZipFmt")]
    public virtual FmtField? PcZipFmt { get; set; }

    [ForeignKey("PtId")]
    [InverseProperty("PtGuar")]
    public virtual Pt Pt { get; set; } = null!;
}
