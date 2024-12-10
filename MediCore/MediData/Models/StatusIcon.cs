using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("status_icon")]
public partial class StatusIcon
{
    [Key]
    [Column("status_icon_id")]
    public int StatusIconId { get; set; }

    [Column("image_file")]
    public byte[] ImageFile { get; set; } = null!;

    [Column("mime_type")]
    [StringLength(20)]
    public string MimeType { get; set; } = null!;

    [Column("status_icon_desc")]
    [StringLength(255)]
    public string StatusIconDesc { get; set; } = null!;

    [Column("seq_no")]
    public int SeqNo { get; set; }

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

    [InverseProperty("StatusIcon")]
    public virtual ICollection<PtStatusIcon> PtStatusIcon { get; set; } = new List<PtStatusIcon>();
}
