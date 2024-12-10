using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtContactId")]
[Table("pt_contact")]
public partial class PtContact
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_contact_id")]
    public int PtContactId { get; set; }

    [Column("contact_typ")]
    public int ContactTyp { get; set; }

    [Column("contact_name")]
    [StringLength(50)]
    public string ContactName { get; set; } = null!;

    [Column("reltn_typ")]
    public int? ReltnTyp { get; set; }

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
    [StringLength(13)]
    public string? BusTelExt { get; set; }

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

    [Column("primary_cont")]
    [StringLength(1)]
    public string? PrimaryCont { get; set; }

    [Column("prv_state_id")]
    public int? PrvStateId { get; set; }

    [Column("same_addr_ind")]
    [StringLength(1)]
    public string? SameAddrInd { get; set; }

    [Column("mobile_tel")]
    [StringLength(28)]
    public string? MobileTel { get; set; }

    [Column("pc_zip_fmt_id")]
    public int? PcZipFmtId { get; set; }

    [Column("bus_tel_fmt_id")]
    public int? BusTelFmtId { get; set; }

    [Column("home_tel_fmt_id")]
    public int? HomeTelFmtId { get; set; }

    [Column("mobile_tel_fmt_id")]
    public int? MobileTelFmtId { get; set; }

    [Column("contact_first_name")]
    [StringLength(30)]
    public string? ContactFirstName { get; set; }

    [ForeignKey("BusTelFmtId")]
    [InverseProperty("PtContactBusTelFmt")]
    public virtual FmtField? BusTelFmt { get; set; }

    [ForeignKey("ContactTyp")]
    [InverseProperty("PtContact")]
    public virtual ContactTyp ContactTypNavigation { get; set; } = null!;

    [ForeignKey("CountryId")]
    [InverseProperty("PtContact")]
    public virtual Country? Country { get; set; }

    [ForeignKey("HomeTelFmtId")]
    [InverseProperty("PtContactHomeTelFmt")]
    public virtual FmtField? HomeTelFmt { get; set; }

    [ForeignKey("PcZipFmtId")]
    [InverseProperty("PtContactPcZipFmt")]
    public virtual FmtField? PcZipFmt { get; set; }

    [ForeignKey("ReltnTyp")]
    [InverseProperty("PtContact")]
    public virtual NextOfKin? ReltnTypNavigation { get; set; }
}
