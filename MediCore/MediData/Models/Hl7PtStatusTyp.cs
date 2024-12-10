using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("Hl7PtStatusTypInstId", "Hl7PtStatusTyp1")]
[Table("hl7_pt_status_typ")]
public partial class Hl7PtStatusTyp
{
    [Key]
    [Column("hl7_pt_status_typ_inst_id")]
    [StringLength(30)]
    public string Hl7PtStatusTypInstId { get; set; } = null!;

    [Key]
    [Column("hl7_pt_status_typ")]
    public int Hl7PtStatusTyp1 { get; set; }

    [Column("hl7_pt_status_typ_abbr")]
    [StringLength(10)]
    public string Hl7PtStatusTypAbbr { get; set; } = null!;

    [Column("hl7_pt_status_typ_desc")]
    [StringLength(255)]
    public string Hl7PtStatusTypDesc { get; set; } = null!;

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string ValidEntryInd { get; set; } = null!;

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

    [InverseProperty("Hl7PtStatusTypNavigation")]
    public virtual ICollection<BillAcct> BillAcct { get; set; } = new List<BillAcct>();
}
