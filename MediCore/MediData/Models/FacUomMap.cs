using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("fac_uom_map")]
public partial class FacUomMap
{
    [Key]
    [Column("fac_uom_map_id")]
    public int FacUomMapId { get; set; }

    [Column("fac_id")]
    public int FacId { get; set; }

    [Column("uom")]
    public int Uom { get; set; }

    [Column("fac_uom_desc")]
    [StringLength(40)]
    public string FacUomDesc { get; set; } = null!;

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

    [ForeignKey("Uom")]
    [InverseProperty("FacUomMap")]
    public virtual UnitOfMeas UomNavigation { get; set; } = null!;
}
