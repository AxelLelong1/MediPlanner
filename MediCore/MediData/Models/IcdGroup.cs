using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("icd_group")]
public partial class IcdGroup
{
    [Key]
    [Column("icd_group_id")]
    public int IcdGroupId { get; set; }

    [Column("icd_group_desc")]
    [StringLength(250)]
    public string IcdGroupDesc { get; set; } = null!;

    [Column("active_ind")]
    [StringLength(1)]
    public string ActiveInd { get; set; } = null!;

    [Column("revision_no")]
    public int RevisionNo { get; set; }

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

    [InverseProperty("IcdGroup")]
    public virtual ICollection<XrefIcdGroup> XrefIcdGroup { get; set; } = new List<XrefIcdGroup>();
}
