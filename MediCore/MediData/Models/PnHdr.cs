using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "PnCorspCd", "FirstPageInd")]
[Table("pn_hdr")]
public partial class PnHdr
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("pn_corsp_cd")]
    [StringLength(1)]
    public string PnCorspCd { get; set; } = null!;

    [Key]
    [Column("first_page_ind")]
    [StringLength(1)]
    public string FirstPageInd { get; set; } = null!;

    [Column("pn_hdr_txt", TypeName = "image")]
    public byte[]? PnHdrTxt { get; set; }

    [Column("valid_blob_ind")]
    [StringLength(1)]
    public string ValidBlobInd { get; set; } = null!;

    [Column("condensed_hdr_ind")]
    [StringLength(1)]
    public string CondensedHdrInd { get; set; } = null!;

    [Column("enable_ltrhd_ind")]
    [StringLength(1)]
    public string EnableLtrhdInd { get; set; } = null!;

    [Column("custom_hdr_ind")]
    [StringLength(1)]
    public string CustomHdrInd { get; set; } = null!;

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
    public string TransLogMuserid { get; set; } = null!;

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string TransLogMinstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
