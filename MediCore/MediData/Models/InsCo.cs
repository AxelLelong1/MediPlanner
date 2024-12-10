using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "InsCoId")]
[Table("ins_co")]
[Index("UpperInsCoName", Name = "nc1_ins_co")]
[Index("IntfInsCoId", Name = "nc2_ins_co")]
public partial class InsCo
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("ins_co_id")]
    public int InsCoId { get; set; }

    [Column("ins_co_name")]
    [StringLength(50)]
    public string InsCoName { get; set; } = null!;

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

    [Column("phone")]
    [StringLength(28)]
    public string? Phone { get; set; }

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

    [Column("prv_state_id")]
    public int? PrvStateId { get; set; }

    [Column("ins_co_parent_id")]
    public int? InsCoParentId { get; set; }

    [Column("intf_ins_co_id")]
    [StringLength(15)]
    public string? IntfInsCoId { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("county")]
    [StringLength(30)]
    public string? County { get; set; }

    [Column("pc_zip_fmt_id")]
    public int? PcZipFmtId { get; set; }

    [Column("phone_fmt_id")]
    public int? PhoneFmtId { get; set; }

    [Column("upper_ins_co_name")]
    [StringLength(50)]
    public string UpperInsCoName { get; set; } = null!;

    [InverseProperty("InsCo")]
    public virtual ICollection<FinancialIns> FinancialIns { get; set; } = new List<FinancialIns>();

    [ForeignKey("InstId, InsCoParentId")]
    [InverseProperty("InsCo")]
    public virtual InsCoParent? InsCoParent { get; set; }

    [ForeignKey("PcZipFmtId")]
    [InverseProperty("InsCoPcZipFmt")]
    public virtual FmtField? PcZipFmt { get; set; }

    [ForeignKey("PhoneFmtId")]
    [InverseProperty("InsCoPhoneFmt")]
    public virtual FmtField? PhoneFmt { get; set; }

    [ForeignKey("PrvStateId")]
    [InverseProperty("InsCo")]
    public virtual PrvState? PrvStateNavigation { get; set; }
}
