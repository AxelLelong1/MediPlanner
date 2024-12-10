using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("ct_dcmnt")]
public partial class CtDcmnt
{
    [Key]
    [Column("ct_dcmnt_id")]
    public int CtDcmntId { get; set; }

    [Column("dcmnt_typ")]
    public int DcmntTyp { get; set; }

    [Column("dcmnt_parent_typ")]
    public int DcmntParentTyp { get; set; }

    [Column("dcmnt_file_name")]
    [StringLength(100)]
    public string? DcmntFileName { get; set; }

    [Column("dcmnt_file_directory")]
    [StringLength(255)]
    public string? DcmntFileDirectory { get; set; }

    [Column("dcmnt_parent_id")]
    public int? DcmntParentId { get; set; }

    [Column("dcmnt_format_typ")]
    public int? DcmntFormatTyp { get; set; }

    [Column("dcmnt_desc")]
    [StringLength(80)]
    public string? DcmntDesc { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

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
