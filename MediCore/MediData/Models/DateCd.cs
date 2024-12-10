using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("date_cd")]
public partial class DateCd
{
    [Key]
    [Column("date_cd")]
    public int DateCd1 { get; set; }

    [Column("date_cd_desc")]
    [StringLength(40)]
    public string DateCdDesc { get; set; } = null!;

    [Column("date_cd_mask")]
    [StringLength(40)]
    public string? DateCdMask { get; set; }

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

    [InverseProperty("OnsetDateCdNavigation")]
    public virtual ICollection<PtAllergy> PtAllergy { get; set; } = new List<PtAllergy>();

    [InverseProperty("PtDobCdNavigation")]
    public virtual ICollection<Pt> PtPtDobCdNavigation { get; set; } = new List<Pt>();

    [InverseProperty("PtDodCdNavigation")]
    public virtual ICollection<Pt> PtPtDodCdNavigation { get; set; } = new List<Pt>();

    [InverseProperty("DateStartedCdNavigation")]
    public virtual ICollection<XrefAgtPt> XrefAgtPt { get; set; } = new List<XrefAgtPt>();
}
