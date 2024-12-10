using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "TransLogTstamp")]
[Table("pt_address")]
public partial class PtAddress
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

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

    [Column("prv_state")]
    [StringLength(30)]
    public string? PrvState { get; set; }

    [Column("pc_zip")]
    [StringLength(10)]
    public string? PcZip { get; set; }

    [Column("country_id")]
    public int? CountryId { get; set; }

    [Column("county")]
    [StringLength(30)]
    public string? County { get; set; }

    [Column("home_tel")]
    [StringLength(28)]
    public string? HomeTel { get; set; }

    [Column("bus_tel")]
    [StringLength(28)]
    public string? BusTel { get; set; }

    [Column("bus_tel_ext")]
    [StringLength(10)]
    public string? BusTelExt { get; set; }

    [Column("fax_tel")]
    [StringLength(28)]
    public string? FaxTel { get; set; }

    [Column("cur_entry")]
    [StringLength(1)]
    public string CurEntry { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Key]
    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

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

    [Column("prv_state_id")]
    public int? PrvStateId { get; set; }

    [Column("email_address")]
    [StringLength(255)]
    public string? EmailAddress { get; set; }

    [Column("mobile_tel")]
    [StringLength(28)]
    public string? MobileTel { get; set; }

    [Column("home_tel_fmt_id")]
    public int? HomeTelFmtId { get; set; }

    [Column("bus_tel_fmt_id")]
    public int? BusTelFmtId { get; set; }

    [Column("mobile_tel_fmt_id")]
    public int? MobileTelFmtId { get; set; }

    [Column("fax_tel_fmt_id")]
    public int? FaxTelFmtId { get; set; }

    [Column("pc_zip_fmt_id")]
    public int? PcZipFmtId { get; set; }

    [Column("mobile_tel_prov_id")]
    public int? MobileTelProvId { get; set; }

    [ForeignKey("BusTelFmtId")]
    [InverseProperty("PtAddressBusTelFmt")]
    public virtual FmtField? BusTelFmt { get; set; }

    [ForeignKey("CountryId")]
    [InverseProperty("PtAddress")]
    public virtual Country? Country { get; set; }

    [ForeignKey("FaxTelFmtId")]
    [InverseProperty("PtAddressFaxTelFmt")]
    public virtual FmtField? FaxTelFmt { get; set; }

    [ForeignKey("HomeTelFmtId")]
    [InverseProperty("PtAddressHomeTelFmt")]
    public virtual FmtField? HomeTelFmt { get; set; }

    [ForeignKey("MobileTelFmtId")]
    [InverseProperty("PtAddressMobileTelFmt")]
    public virtual FmtField? MobileTelFmt { get; set; }

    [ForeignKey("PcZipFmtId")]
    [InverseProperty("PtAddressPcZipFmt")]
    public virtual FmtField? PcZipFmt { get; set; }

    [ForeignKey("PrvStateId")]
    [InverseProperty("PtAddress")]
    public virtual PrvState? PrvStateNavigation { get; set; }
}
