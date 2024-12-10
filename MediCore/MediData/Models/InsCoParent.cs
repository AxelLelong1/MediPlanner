using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "InsCoParentId")]
[Table("ins_co_parent")]
public partial class InsCoParent
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("ins_co_parent_id")]
    public int InsCoParentId { get; set; }

    [Column("ins_co_parent_desc")]
    [StringLength(50)]
    public string InsCoParentDesc { get; set; } = null!;

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

    [Column("pc_zip")]
    [StringLength(10)]
    public string? PcZip { get; set; }

    [Column("phone_no")]
    [StringLength(28)]
    public string? PhoneNo { get; set; }

    [Column("country_id")]
    public int? CountryId { get; set; }

    [Column("prv_state_id")]
    public int? PrvStateId { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string TransLogMuserid { get; set; } = null!;

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string TransLogMinstId { get; set; } = null!;

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime TransLogMtstamp { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("indep_ind")]
    [StringLength(1)]
    public string? IndepInd { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("county")]
    [StringLength(30)]
    public string? County { get; set; }

    [Column("prv_state")]
    [StringLength(30)]
    public string? PrvState { get; set; }

    [Column("pc_zip_fmt_id")]
    public int? PcZipFmtId { get; set; }

    [Column("phone_no_fmt_id")]
    public int? PhoneNoFmtId { get; set; }

    [ForeignKey("CountryId")]
    [InverseProperty("InsCoParent")]
    public virtual Country? Country { get; set; }

    [InverseProperty("InsCoParent")]
    public virtual ICollection<InsCo> InsCo { get; set; } = new List<InsCo>();

    [InverseProperty("InsCoParent")]
    public virtual ICollection<InsRqstn> InsRqstn { get; set; } = new List<InsRqstn>();

    [ForeignKey("PcZipFmtId")]
    [InverseProperty("InsCoParentPcZipFmt")]
    public virtual FmtField? PcZipFmt { get; set; }

    [ForeignKey("PhoneNoFmtId")]
    [InverseProperty("InsCoParentPhoneNoFmt")]
    public virtual FmtField? PhoneNoFmt { get; set; }

    [ForeignKey("PrvStateId")]
    [InverseProperty("InsCoParent")]
    public virtual PrvState? PrvStateNavigation { get; set; }
}
