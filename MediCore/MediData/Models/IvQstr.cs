using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("iv_qstr")]
public partial class IvQstr
{
    [Key]
    [Column("iv_qstr_id")]
    public int IvQstrId { get; set; }

    [Column("iv_qstr_name")]
    [StringLength(40)]
    public string IvQstrName { get; set; } = null!;

    [Column("iv_qstr_prelim_txt")]
    [StringLength(255)]
    public string? IvQstrPrelimTxt { get; set; }

    [Column("active_entry_ind")]
    [StringLength(1)]
    public string ActiveEntryInd { get; set; } = null!;

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
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [InverseProperty("IvQstr")]
    public virtual ICollection<IvQstrCat> IvQstrCat { get; set; } = new List<IvQstrCat>();

    [InverseProperty("IvQstr")]
    public virtual ICollection<PtIv> PtIv { get; set; } = new List<PtIv>();
}
