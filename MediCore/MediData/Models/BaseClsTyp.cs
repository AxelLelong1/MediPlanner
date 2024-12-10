using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("base_cls_typ")]
public partial class BaseClsTyp
{
    [Key]
    [Column("base_cls_typ")]
    public int BaseClsTyp1 { get; set; }

    [Column("base_desc")]
    [StringLength(30)]
    public string BaseDesc { get; set; } = null!;

    [Column("base_cd_typ")]
    [StringLength(1)]
    public string BaseCdTyp { get; set; } = null!;

    [Column("inst_based_ind")]
    [StringLength(1)]
    public string InstBasedInd { get; set; } = null!;

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

    [Column("cat_ind")]
    [StringLength(1)]
    public string? CatInd { get; set; }

    [InverseProperty("RequestTypNavigation")]
    public virtual ICollection<PtInfoRequest> PtInfoRequest { get; set; } = new List<PtInfoRequest>();

    [InverseProperty("PtPreferTypNavigation")]
    public virtual ICollection<PtPrefer> PtPrefer { get; set; } = new List<PtPrefer>();
}
