using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("erx_ptt_seg")]
[Index("ErxSegRefId", Name = "nc1_erx_ptt_seg")]
public partial class ErxPttSeg
{
    [Key]
    [Column("erx_ptt_id")]
    public int ErxPttId { get; set; }

    [Column("erx_seg_ref_id")]
    public int? ErxSegRefId { get; set; }

    [Column("dob", TypeName = "datetime")]
    public DateTime? Dob { get; set; }

    [Column("pt_last_name")]
    [StringLength(35)]
    public string? PtLastName { get; set; }

    [Column("pt_first_name")]
    [StringLength(35)]
    public string? PtFirstName { get; set; }

    [Column("pt_init")]
    [StringLength(35)]
    public string? PtInit { get; set; }

    [Column("pt_suffix")]
    [StringLength(10)]
    public string? PtSuffix { get; set; }

    [Column("pt_prefix")]
    [StringLength(10)]
    public string? PtPrefix { get; set; }

    [Column("gender")]
    [StringLength(3)]
    public string? Gender { get; set; }

    [Column("pt_identifier")]
    [StringLength(35)]
    public string? PtIdentifier { get; set; }

    [Column("pt_id_cd")]
    [StringLength(3)]
    public string? PtIdCd { get; set; }

    [Column("addr_1")]
    [StringLength(35)]
    public string? Addr1 { get; set; }

    [Column("city")]
    [StringLength(35)]
    public string? City { get; set; }

    [Column("state")]
    [StringLength(2)]
    public string? State { get; set; }

    [Column("country")]
    [StringLength(2)]
    public string? Country { get; set; }

    [Column("zip_cd")]
    [StringLength(9)]
    public string? ZipCd { get; set; }

    [Column("addr_2_cd")]
    [StringLength(3)]
    public string? Addr2Cd { get; set; }

    [Column("addr_2")]
    [StringLength(35)]
    public string? Addr2 { get; set; }

    [Column("email")]
    [StringLength(80)]
    public string? Email { get; set; }

    [Column("pt_reltn")]
    [StringLength(3)]
    public string? PtReltn { get; set; }

    [Column("msg_typ")]
    [StringLength(8)]
    public string? MsgTyp { get; set; }
}
