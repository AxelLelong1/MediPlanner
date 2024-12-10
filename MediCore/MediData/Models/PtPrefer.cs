using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtPreferTyp")]
[Table("pt_prefer")]
public partial class PtPrefer
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_prefer_typ")]
    public int PtPreferTyp { get; set; }

    [Column("pt_prefer_value_typ")]
    public int? PtPreferValueTyp { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

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

    [Column("revision_no")]
    public int RevisionNo { get; set; }

    [ForeignKey("PtId")]
    [InverseProperty("PtPrefer")]
    public virtual Pt Pt { get; set; } = null!;

    [ForeignKey("PtPreferTyp")]
    [InverseProperty("PtPrefer")]
    public virtual BaseClsTyp PtPreferTypNavigation { get; set; } = null!;

    [ForeignKey("PtPreferValueTyp")]
    [InverseProperty("PtPrefer")]
    public virtual BaseTyp? PtPreferValueTypNavigation { get; set; }
}
