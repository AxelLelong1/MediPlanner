using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "OncoPtFsDetId", "OncoPtFsDrugId")]
[Table("onco_pt_fs_drug")]
public partial class OncoPtFsDrug
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("onco_pt_fs_det_id")]
    [StringLength(25)]
    public string OncoPtFsDetId { get; set; } = null!;

    [Key]
    [Column("onco_pt_fs_drug_id")]
    [StringLength(25)]
    public string OncoPtFsDrugId { get; set; } = null!;

    [Column("drug_name")]
    [StringLength(200)]
    public string? DrugName { get; set; }

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

    [ForeignKey("PtId, OncoPtFsDetId")]
    [InverseProperty("OncoPtFsDrug")]
    public virtual OncoPtFsDet OncoPtFsDet { get; set; } = null!;

    [InverseProperty("OncoPtFsDrug")]
    public virtual ICollection<OncoPtFsDrugDet> OncoPtFsDrugDet { get; set; } = new List<OncoPtFsDrugDet>();
}
