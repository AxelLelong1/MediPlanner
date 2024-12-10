using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("erx_due_seg")]
public partial class ErxDueSeg
{
    [Key]
    [Column("erx_due_id")]
    public int ErxDueId { get; set; }

    [Column("erx_drug_id")]
    public int? ErxDrugId { get; set; }

    [Column("srvc_rsn_cd")]
    [StringLength(2)]
    public string? SrvcRsnCd { get; set; }

    [Column("prof_srvc_cd")]
    [StringLength(2)]
    public string? ProfSrvcCd { get; set; }

    [Column("srvc_result_cd")]
    [StringLength(2)]
    public string? SrvcResultCd { get; set; }

    [Column("co_agt_id")]
    [StringLength(20)]
    public string? CoAgtId { get; set; }

    [Column("co_agt_qual")]
    [StringLength(2)]
    public string? CoAgtQual { get; set; }

    [Column("clinic_sig_cd")]
    [StringLength(1)]
    public string? ClinicSigCd { get; set; }

    [Column("ack_reason")]
    [StringLength(100)]
    public string? AckReason { get; set; }

    [Column("msg_typ")]
    [StringLength(8)]
    public string? MsgTyp { get; set; }
}
