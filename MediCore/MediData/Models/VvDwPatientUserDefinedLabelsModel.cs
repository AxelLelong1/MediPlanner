using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDwPatientUserDefinedLabelsModel
{
    [StringLength(25)]
    public string PatientId { get; set; } = null!;

    [Column("UDFValue1")]
    [StringLength(16)]
    public string? Udfvalue1 { get; set; }

    [Column("UDFValue2")]
    [StringLength(16)]
    public string? Udfvalue2 { get; set; }

    [Column("UDFValue3")]
    [StringLength(16)]
    public string? Udfvalue3 { get; set; }

    [Column("UDFValue4")]
    [StringLength(16)]
    public string? Udfvalue4 { get; set; }

    [Column("UDFValue5")]
    [StringLength(16)]
    public string? Udfvalue5 { get; set; }

    [Column("UDFValue6")]
    [StringLength(16)]
    public string? Udfvalue6 { get; set; }

    [Column("UDFValue7")]
    [StringLength(16)]
    public string? Udfvalue7 { get; set; }

    [Column("UDFValue8")]
    [StringLength(16)]
    public string? Udfvalue8 { get; set; }

    [Column("UDFValue9")]
    [StringLength(16)]
    public string? Udfvalue9 { get; set; }

    [Column("UDFValue10")]
    [StringLength(16)]
    public string? Udfvalue10 { get; set; }

    [Column("UDFValue11")]
    [StringLength(16)]
    public string? Udfvalue11 { get; set; }

    [Column("UDFValue12")]
    [StringLength(16)]
    public string? Udfvalue12 { get; set; }

    [Column("UDFValue13")]
    [StringLength(16)]
    public string? Udfvalue13 { get; set; }

    [Column("UDFValue14")]
    [StringLength(16)]
    public string? Udfvalue14 { get; set; }

    [Column("UDFValue15")]
    [StringLength(16)]
    public string? Udfvalue15 { get; set; }

    [Column("UDFValue16")]
    [StringLength(16)]
    public string? Udfvalue16 { get; set; }

    [Column("ctrPatientSer")]
    public long CtrPatientSer { get; set; }
}
