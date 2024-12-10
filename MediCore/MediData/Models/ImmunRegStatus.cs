﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("immun_reg_status")]
public partial class ImmunRegStatus
{
    [Key]
    [Column("immun_reg_status_id")]
    public int ImmunRegStatusId { get; set; }

    [Column("base_typ")]
    public int BaseTyp { get; set; }

    [Column("immun_reg_status_desc")]
    [StringLength(85)]
    public string? ImmunRegStatusDesc { get; set; }

    [Column("hl7_immun_reg_status")]
    [StringLength(3)]
    public string? Hl7ImmunRegStatus { get; set; }

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

    [ForeignKey("BaseTyp")]
    [InverseProperty("ImmunRegStatus")]
    public virtual BaseTyp BaseTypNavigation { get; set; } = null!;
}
