using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("DrugDescId", "AgtLookupTypId")]
[Table("agt_lookup")]
public partial class AgtLookup
{
    [Key]
    [Column("drug_desc_id")]
    [StringLength(6)]
    public string DrugDescId { get; set; } = null!;

    [Key]
    [Column("agt_lookup_typ_id")]
    public int AgtLookupTypId { get; set; }

    [Column("external_cd")]
    [StringLength(30)]
    public string ExternalCd { get; set; } = null!;

    [Column("short_name")]
    [StringLength(100)]
    public string? ShortName { get; set; }

    [Column("full_name")]
    [StringLength(250)]
    public string? FullName { get; set; }

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

    [ForeignKey("AgtLookupTypId")]
    [InverseProperty("AgtLookup")]
    public virtual AgtLookupTyp AgtLookupTyp { get; set; } = null!;
}
