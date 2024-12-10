using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "FacId")]
[Table("fac")]
public partial class Fac
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("fac_id")]
    public int FacId { get; set; }

    [Column("fac_name")]
    [StringLength(50)]
    public string FacName { get; set; } = null!;

    [Column("fac_address_1")]
    [StringLength(30)]
    public string FacAddress1 { get; set; } = null!;

    [Column("fac_address_2")]
    [StringLength(30)]
    public string? FacAddress2 { get; set; }

    [Column("fac_address_3")]
    [StringLength(30)]
    public string? FacAddress3 { get; set; }

    [Column("fac_city")]
    [StringLength(30)]
    public string FacCity { get; set; } = null!;

    [Column("fac_county")]
    [StringLength(30)]
    public string? FacCounty { get; set; }

    [Column("fac_prv_state")]
    [StringLength(30)]
    public string FacPrvState { get; set; } = null!;

    [Column("country_id")]
    public int? CountryId { get; set; }

    [Column("fac_pc_zip")]
    [StringLength(10)]
    public string FacPcZip { get; set; } = null!;

    [Column("fac_tel")]
    [StringLength(28)]
    public string FacTel { get; set; } = null!;

    [Column("fac_tel_ext")]
    [StringLength(10)]
    public string? FacTelExt { get; set; }

    [Column("fac_typ")]
    public int? FacTyp { get; set; }

    [Column("hl7_flag")]
    [StringLength(1)]
    public string? Hl7Flag { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

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

    [Column("prv_state_id")]
    public int? PrvStateId { get; set; }

    [Column("fac_pc_zip_fmt_id")]
    public int? FacPcZipFmtId { get; set; }

    [Column("fac_tel_fmt_id")]
    public int? FacTelFmtId { get; set; }

    [ForeignKey("CountryId")]
    [InverseProperty("Fac")]
    public virtual Country? Country { get; set; }

    [ForeignKey("FacPcZipFmtId")]
    [InverseProperty("FacFacPcZipFmt")]
    public virtual FmtField? FacPcZipFmt { get; set; }

    [InverseProperty("Fac")]
    public virtual ICollection<FacRqstn> FacRqstn { get; set; } = new List<FacRqstn>();

    [ForeignKey("FacTelFmtId")]
    [InverseProperty("FacFacTelFmt")]
    public virtual FmtField? FacTelFmt { get; set; }

    [ForeignKey("FacTyp")]
    [InverseProperty("Fac")]
    public virtual FacTyp? FacTypNavigation { get; set; }

    [ForeignKey("InstId")]
    [InverseProperty("Fac")]
    public virtual Inst Inst { get; set; } = null!;

    [InverseProperty("Fac")]
    public virtual ICollection<LblFormInst> LblFormInst { get; set; } = new List<LblFormInst>();
}
