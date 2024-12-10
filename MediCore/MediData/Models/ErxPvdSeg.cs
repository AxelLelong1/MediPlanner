using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("erx_pvd_seg")]
[Index("ErxSegRefId", Name = "nc1_erx_pvd_seg")]
public partial class ErxPvdSeg
{
    [Key]
    [Column("erx_pvd_id")]
    public int ErxPvdId { get; set; }

    [Column("erx_seg_ref_id")]
    public int? ErxSegRefId { get; set; }

    [Column("prov_cd")]
    [StringLength(5)]
    public string? ProvCd { get; set; }

    [Column("prov_spec_typ_cd")]
    [StringLength(3)]
    public string? ProvSpecTypCd { get; set; }

    [Column("prov_spec_cd")]
    [StringLength(10)]
    public string? ProvSpecCd { get; set; }

    [Column("prov_last_name")]
    [StringLength(35)]
    public string? ProvLastName { get; set; }

    [Column("prov_first_name")]
    [StringLength(35)]
    public string? ProvFirstName { get; set; }

    [Column("prov_init")]
    [StringLength(35)]
    public string? ProvInit { get; set; }

    [Column("prov_suffix")]
    [StringLength(10)]
    public string? ProvSuffix { get; set; }

    [Column("prov_prefix")]
    [StringLength(10)]
    public string? ProvPrefix { get; set; }

    [Column("prov_email")]
    [StringLength(255)]
    public string? ProvEmail { get; set; }

    [Column("clinic_name")]
    [StringLength(35)]
    public string? ClinicName { get; set; }

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

    [Column("agt_last_name")]
    [StringLength(35)]
    public string? AgtLastName { get; set; }

    [Column("agt_first_name")]
    [StringLength(35)]
    public string? AgtFirstName { get; set; }

    [Column("agt_init")]
    [StringLength(35)]
    public string? AgtInit { get; set; }

    [Column("agt_suffix")]
    [StringLength(10)]
    public string? AgtSuffix { get; set; }

    [Column("agt_prefix")]
    [StringLength(10)]
    public string? AgtPrefix { get; set; }

    [Column("msg_typ")]
    [StringLength(8)]
    public string? MsgTyp { get; set; }
}
