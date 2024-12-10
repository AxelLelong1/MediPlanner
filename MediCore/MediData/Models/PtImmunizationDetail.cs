using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("pt_immunization_detail")]
public partial class PtImmunizationDetail
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Column("communicate_cd")]
    public int? CommunicateCd { get; set; }

    [Column("communicate_eff_date", TypeName = "datetime")]
    public DateTime? CommunicateEffDate { get; set; }

    [Column("disclose_ind")]
    [StringLength(1)]
    public string? DiscloseInd { get; set; }

    [Column("immunization_reg_status")]
    public int? ImmunizationRegStatus { get; set; }

    [Column("immunization_reg_status_date", TypeName = "datetime")]
    public DateTime? ImmunizationRegStatusDate { get; set; }

    [Column("vfc_eligibility")]
    public int? VfcEligibility { get; set; }

    [Column("nok_surname")]
    [StringLength(30)]
    public string? NokSurname { get; set; }

    [Column("nok_given_name")]
    [StringLength(30)]
    public string? NokGivenName { get; set; }

    [Column("nok_reltn_typ")]
    public int? NokReltnTyp { get; set; }

    [Column("nok_address")]
    [StringLength(50)]
    public string? NokAddress { get; set; }

    [Column("nok_city")]
    [StringLength(50)]
    public string? NokCity { get; set; }

    [Column("nok_prv_state")]
    [StringLength(30)]
    public string? NokPrvState { get; set; }

    [Column("nok_pc_zip")]
    [StringLength(10)]
    public string? NokPcZip { get; set; }

    [Column("nok_country_id")]
    public int? NokCountryId { get; set; }

    [Column("nok_telecom_use_cd")]
    public int? NokTelecomUseCd { get; set; }

    [Column("nok_telecom_equip_typ")]
    public int? NokTelecomEquipTyp { get; set; }

    [Column("nok_email_addr")]
    [StringLength(50)]
    public string? NokEmailAddr { get; set; }

    [Column("nok_tel_area_cd")]
    [StringLength(28)]
    public string? NokTelAreaCd { get; set; }

    [Column("nok_tel_local_num")]
    [StringLength(28)]
    public string? NokTelLocalNum { get; set; }

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
}
