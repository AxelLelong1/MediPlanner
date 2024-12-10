using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("hl7_link")]
[Index("SrcRecordSeqNo", Name = "nc1_hl7_link")]
[Index("DestRecordSeqNo", Name = "nc2_hl7_link")]
public partial class Hl7Link
{
    [Key]
    [Column("hl7_link_id")]
    [StringLength(10)]
    public string Hl7LinkId { get; set; } = null!;

    [Column("src_record_seq_no")]
    public int SrcRecordSeqNo { get; set; }

    [Column("src_record_direction")]
    [StringLength(1)]
    public string SrcRecordDirection { get; set; } = null!;

    [Column("dest_record_seq_no")]
    public int DestRecordSeqNo { get; set; }

    [Column("dest_record_direction")]
    [StringLength(1)]
    public string DestRecordDirection { get; set; } = null!;

    [Column("link_typ")]
    [StringLength(1)]
    public string LinkTyp { get; set; } = null!;

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

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
