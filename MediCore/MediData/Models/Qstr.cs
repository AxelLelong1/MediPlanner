using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("qstr")]
public partial class Qstr
{
    [Key]
    [Column("qstr_name")]
    [StringLength(20)]
    public string QstrName { get; set; } = null!;

    [Column("qstr_typ")]
    public int QstrTyp { get; set; }

    [Column("title")]
    [StringLength(50)]
    public string Title { get; set; } = null!;

    [Column("appr_flag")]
    [StringLength(1)]
    public string ApprFlag { get; set; } = null!;

    [Column("instr")]
    public string? Instr { get; set; }

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

    [Column("active_entry_ind")]
    [StringLength(1)]
    public string? ActiveEntryInd { get; set; }

    [Column("pt_enter_ind")]
    [StringLength(1)]
    public string? PtEnterInd { get; set; }

    [Column("pt_enter_seq_no")]
    public int? PtEnterSeqNo { get; set; }

    [Column("pn_qstr_id")]
    public int? PnQstrId { get; set; }

    [InverseProperty("QstrNameNavigation")]
    public virtual ICollection<QstrBill> QstrBill { get; set; } = new List<QstrBill>();

    [ForeignKey("QstrTyp")]
    [InverseProperty("Qstr")]
    public virtual QstrTyp QstrTypNavigation { get; set; } = null!;

    [InverseProperty("QstrNameNavigation")]
    public virtual ICollection<Question> Question { get; set; } = new List<Question>();

    [InverseProperty("QstrNameNavigation")]
    public virtual ICollection<TpQstr> TpQstr { get; set; } = new List<TpQstr>();
}
