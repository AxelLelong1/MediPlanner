using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("nok_relationship")]
public partial class NokRelationship
{
    [Key]
    [Column("nok_relationship_id")]
    public int NokRelationshipId { get; set; }

    [Column("base_typ")]
    public int BaseTyp { get; set; }

    [Column("nok_relationship_desc")]
    [StringLength(72)]
    public string? NokRelationshipDesc { get; set; }

    [Column("hl7_nok_relationship")]
    [StringLength(3)]
    public string? Hl7NokRelationship { get; set; }

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
    [InverseProperty("NokRelationship")]
    public virtual BaseTyp BaseTypNavigation { get; set; } = null!;
}
