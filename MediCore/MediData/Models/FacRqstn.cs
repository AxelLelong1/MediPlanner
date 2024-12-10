using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "FacId", "FacRqstnNo")]
[Table("fac_rqstn")]
public partial class FacRqstn
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("fac_id")]
    public int FacId { get; set; }

    [Key]
    [Column("fac_rqstn_no")]
    [StringLength(20)]
    public string FacRqstnNo { get; set; } = null!;

    [Column("fac_rqstn_desc")]
    [StringLength(40)]
    public string FacRqstnDesc { get; set; } = null!;

    [Column("prty_of_rqstn")]
    public int PrtyOfRqstn { get; set; }

    [Column("elctrnc_transfer")]
    [StringLength(1)]
    public string ElctrncTransfer { get; set; } = null!;

    [Column("include_spcmn")]
    [StringLength(1)]
    public string IncludeSpcmn { get; set; } = null!;

    [Column("print_rqstn_flag")]
    [StringLength(1)]
    public string PrintRqstnFlag { get; set; } = null!;

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

    [Column("active_ind")]
    [StringLength(1)]
    public string? ActiveInd { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("billable_ind")]
    [StringLength(1)]
    public string? BillableInd { get; set; }

    [Column("fixed_font_ind")]
    [StringLength(1)]
    public string? FixedFontInd { get; set; }

    [Column("gnrc_rqstn_ind")]
    [StringLength(1)]
    public string? GnrcRqstnInd { get; set; }

    [Column("vitals_ind")]
    [StringLength(30)]
    public string? VitalsInd { get; set; }

    [ForeignKey("InstId, FacId")]
    [InverseProperty("FacRqstn")]
    public virtual Fac Fac { get; set; } = null!;

    [InverseProperty("FacRqstn")]
    public virtual ICollection<FacRqstnCat> FacRqstnCat { get; set; } = new List<FacRqstnCat>();

    [InverseProperty("FacRqstn")]
    public virtual ICollection<InsRqstn> InsRqstn { get; set; } = new List<InsRqstn>();

    [InverseProperty("FacRqstn")]
    public virtual ICollection<Test> Test { get; set; } = new List<Test>();

    [InverseProperty("FacRqstn")]
    public virtual ICollection<XrefInstRqstn> XrefInstRqstn { get; set; } = new List<XrefInstRqstn>();
}
