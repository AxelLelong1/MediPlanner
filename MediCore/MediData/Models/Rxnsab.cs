using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("RXNSAB")]
public partial class Rxnsab
{
    [Key]
    [Column("VCUI")]
    [StringLength(8)]
    public string Vcui { get; set; } = null!;

    [Column("RCUI")]
    [StringLength(8)]
    public string? Rcui { get; set; }

    [Column("VSAB")]
    [StringLength(20)]
    public string? Vsab { get; set; }

    [Column("RSAB")]
    [StringLength(20)]
    public string Rsab { get; set; } = null!;

    [Column("SON")]
    [StringLength(3000)]
    public string? Son { get; set; }

    [Column("SF")]
    [StringLength(20)]
    public string? Sf { get; set; }

    [Column("SVER")]
    [StringLength(20)]
    public string? Sver { get; set; }

    [Column("VSTART")]
    [StringLength(10)]
    public string? Vstart { get; set; }

    [Column("VEND")]
    [StringLength(10)]
    public string? Vend { get; set; }

    [Column("IMETA")]
    [StringLength(10)]
    public string? Imeta { get; set; }

    [Column("RMETA")]
    [StringLength(10)]
    public string? Rmeta { get; set; }

    [Column("SLC")]
    [StringLength(1000)]
    public string? Slc { get; set; }

    [Column("SCC")]
    [StringLength(1000)]
    public string? Scc { get; set; }

    [Column("SRL")]
    public int? Srl { get; set; }

    [Column("TFR")]
    public int? Tfr { get; set; }

    [Column("CFR")]
    public int? Cfr { get; set; }

    [Column("CXTY")]
    [StringLength(50)]
    public string? Cxty { get; set; }

    [Column("TTYL")]
    [StringLength(100)]
    public string? Ttyl { get; set; }

    [Column("ATNL")]
    [StringLength(1000)]
    public string? Atnl { get; set; }

    [Column("LAT")]
    [StringLength(3)]
    public string? Lat { get; set; }

    [Column("CENC")]
    [StringLength(20)]
    public string? Cenc { get; set; }

    [Column("CURVER")]
    [StringLength(1)]
    public string? Curver { get; set; }

    [Column("SABIN")]
    [StringLength(1)]
    public string? Sabin { get; set; }

    [Column("SSN")]
    [StringLength(3000)]
    public string? Ssn { get; set; }

    [Column("SCIT")]
    [StringLength(4000)]
    public string? Scit { get; set; }

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
