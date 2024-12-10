using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("IntfTrgr")]
public partial class IntfTrgr1
{
    [Key]
    public long IntfTrgrSer { get; set; }

    public int? FacId { get; set; }

    [StringLength(32)]
    public string? InstId { get; set; }

    [StringLength(16)]
    public string? MsgEvntTyp { get; set; }

    [StringLength(16)]
    public string? MsgTyp { get; set; }

    [StringLength(16)]
    public string? OrderTyp { get; set; }

    [StringLength(16)]
    public string? TrgrStatusInd { get; set; }

    [StringLength(16)]
    public string? IntfAppParmIdNoTrgr { get; set; }

    [StringLength(16)]
    public string? IntfAppParmIdTrgr { get; set; }

    [StringLength(255)]
    public string? UserId { get; set; }

    [StringLength(32)]
    public string? UserInstId { get; set; }

    [StringLength(16)]
    public string? AppCd { get; set; }

    [StringLength(64)]
    public string? KeyName1 { get; set; }

    [StringLength(64)]
    public string? KeyName2 { get; set; }

    [StringLength(64)]
    public string? KeyName3 { get; set; }

    [StringLength(64)]
    public string? KeyName4 { get; set; }

    [StringLength(64)]
    public string? KeyName5 { get; set; }

    [StringLength(64)]
    public string? KeyName6 { get; set; }

    [StringLength(64)]
    public string? KeyName7 { get; set; }

    [StringLength(64)]
    public string? KeyName8 { get; set; }

    [StringLength(64)]
    public string? KeyName9 { get; set; }

    [StringLength(64)]
    public string? KeyName10 { get; set; }

    [StringLength(64)]
    public string? KeyValue1 { get; set; }

    [StringLength(64)]
    public string? KeyValue2 { get; set; }

    [StringLength(64)]
    public string? KeyValue3 { get; set; }

    [StringLength(64)]
    public string? KeyValue4 { get; set; }

    [StringLength(64)]
    public string? KeyValue5 { get; set; }

    [StringLength(64)]
    public string? KeyValue6 { get; set; }

    [StringLength(64)]
    public string? KeyValue7 { get; set; }

    [StringLength(64)]
    public string? KeyValue8 { get; set; }

    [StringLength(64)]
    public string? KeyValue9 { get; set; }

    [StringLength(64)]
    public string? KeyValue10 { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }
}
