using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "BaseTypId")]
[Table("inst_base_typ")]
[Index("InstId", "BaseClsTyp", Name = "nc1_inst_base_typ")]
public partial class InstBaseTyp
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("base_typ_id")]
    public int BaseTypId { get; set; }

    [Column("base_cls_typ")]
    public int BaseClsTyp { get; set; }

    [Column("base_desc")]
    [StringLength(100)]
    public string BaseDesc { get; set; } = null!;

    [Column("cat_desc")]
    [StringLength(50)]
    public string? CatDesc { get; set; }

    [Column("seq_no")]
    public int? SeqNo { get; set; }

    [Column("active_entry_ind")]
    [StringLength(1)]
    public string? ActiveEntryInd { get; set; }

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

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("revision_no")]
    public int? RevisionNo { get; set; }

    [InverseProperty("InstBaseTyp")]
    public virtual ICollection<BaseTypPtListQueryXref> BaseTypPtListQueryXref { get; set; } = new List<BaseTypPtListQueryXref>();

    [InverseProperty("InstBaseTyp")]
    public virtual ICollection<EducationResource> EducationResource { get; set; } = new List<EducationResource>();
}
