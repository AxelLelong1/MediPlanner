using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("erx_phone")]
[Index("ErxSegRefId", Name = "nc1_erx_phone")]
public partial class ErxPhone
{
    [Key]
    [Column("erx_phone_id")]
    public int ErxPhoneId { get; set; }

    [Column("erx_seg_ref_id")]
    public int? ErxSegRefId { get; set; }

    [Column("erx_seg")]
    [StringLength(5)]
    public string? ErxSeg { get; set; }

    [Column("phone_no")]
    [StringLength(80)]
    public string? PhoneNo { get; set; }

    [Column("phone_no_cd")]
    [StringLength(3)]
    public string? PhoneNoCd { get; set; }

    [Column("msg_typ")]
    [StringLength(8)]
    public string? MsgTyp { get; set; }
}
