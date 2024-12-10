using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("telecom_use_cd")]
public partial class TelecomUseCd
{
    [Key]
    [Column("telecom_use_cd_id")]
    public int TelecomUseCdId { get; set; }

    [Column("base_typ")]
    public int BaseTyp { get; set; }

    [Column("telecom_use_cd_desc")]
    [StringLength(30)]
    public string? TelecomUseCdDesc { get; set; }

    [Column("hl7_telecom_use_cd")]
    [StringLength(3)]
    public string? Hl7TelecomUseCd { get; set; }

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
    [InverseProperty("TelecomUseCd")]
    public virtual BaseTyp BaseTypNavigation { get; set; } = null!;
}
