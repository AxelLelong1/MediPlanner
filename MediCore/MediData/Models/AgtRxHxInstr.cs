using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "InstrId")]
[Table("agt_rx_hx_instr")]
public partial class AgtRxHxInstr
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("instr_id")]
    public int InstrId { get; set; }

    [Column("pt_visit_id")]
    public int PtVisitId { get; set; }

    [Column("rx_id")]
    public int RxId { get; set; }

    [Column("item_no")]
    public int ItemNo { get; set; }

    [Column("instr_userid")]
    [StringLength(255)]
    public string? InstrUserid { get; set; }

    [Column("instr_inst_id")]
    [StringLength(30)]
    public string? InstrInstId { get; set; }

    [Column("general_orders_hx")]
    public string GeneralOrdersHx { get; set; } = null!;

    [Column("hx_entry_ind")]
    [StringLength(1)]
    public string HxEntryInd { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
