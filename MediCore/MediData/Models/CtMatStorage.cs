using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("ct_mat_storage")]
public partial class CtMatStorage
{
    [Key]
    [Column("mat_storage_id")]
    public int MatStorageId { get; set; }

    [Column("tp_name")]
    [StringLength(20)]
    public string TpName { get; set; } = null!;

    [Column("mat_typ")]
    public int? MatTyp { get; set; }

    [Column("box_desc")]
    [StringLength(60)]
    public string? BoxDesc { get; set; }

    [Column("loc_desc")]
    [StringLength(60)]
    public string? LocDesc { get; set; }

    [Column("mat_moved_stkh_id")]
    [StringLength(20)]
    public string? MatMovedStkhId { get; set; }

    [Column("moved_date", TypeName = "datetime")]
    public DateTime? MovedDate { get; set; }

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
}
