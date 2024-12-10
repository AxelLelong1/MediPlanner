using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("agt_manufacturer")]
public partial class AgtManufacturer
{
    [Key]
    [Column("agt_manufacturer_id")]
    public int AgtManufacturerId { get; set; }

    [Column("manufacturer_name")]
    [StringLength(30)]
    public string? ManufacturerName { get; set; }

    [Column("full_name")]
    [StringLength(250)]
    public string? FullName { get; set; }

    [Column("mvx_code")]
    [StringLength(5)]
    public string? MvxCode { get; set; }

    [Column("manufacturer_grp")]
    [StringLength(10)]
    public string? ManufacturerGrp { get; set; }

    [Column("revision_no")]
    public int RevisionNo { get; set; }

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
}
