using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("intf_pt_select_config")]
public partial class IntfPtSelectConfig
{
    [Key]
    [Column("intf_pt_select_config_id")]
    public int IntfPtSelectConfigId { get; set; }

    [Column("column_label")]
    [StringLength(30)]
    public string? ColumnLabel { get; set; }

    [Column("varis_stored_proc_name")]
    [StringLength(30)]
    public string? VarisStoredProcName { get; set; }

    [Column("varis_parameter_name")]
    [StringLength(30)]
    public string? VarisParameterName { get; set; }

    [Column("hl7_segment_name")]
    [StringLength(30)]
    public string? Hl7SegmentName { get; set; }

    [Column("hl7_field_no")]
    public int? Hl7FieldNo { get; set; }

    [Column("hl7_comp_no")]
    public int? Hl7CompNo { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;
}
