using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("erx_obs_seg")]
public partial class ErxObsSeg
{
    [Key]
    [Column("erx_obs_id")]
    public int ErxObsId { get; set; }

    [Column("erx_seg_ref_id")]
    public int? ErxSegRefId { get; set; }

    [Column("meas_dimension")]
    [StringLength(3)]
    public string? MeasDimension { get; set; }

    [Column("meas_value")]
    [StringLength(20)]
    public string? MeasValue { get; set; }

    [Column("obs_date", TypeName = "datetime")]
    public DateTime? ObsDate { get; set; }

    [Column("meas_data_qual")]
    [StringLength(3)]
    public string? MeasDataQual { get; set; }

    [Column("meas_src_cd")]
    [StringLength(3)]
    public string? MeasSrcCd { get; set; }

    [Column("meas_unit_cd")]
    [StringLength(15)]
    public string? MeasUnitCd { get; set; }

    [Column("msg_typ")]
    [StringLength(8)]
    public string? MsgTyp { get; set; }
}
