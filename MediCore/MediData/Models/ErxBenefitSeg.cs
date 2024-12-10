using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("erx_benefit_seg")]
public partial class ErxBenefitSeg
{
    [Key]
    [Column("erx_benefit_id")]
    public int ErxBenefitId { get; set; }

    [Column("erx_seg_ref_id")]
    public int ErxSegRefId { get; set; }

    [Column("payer_name")]
    [StringLength(35)]
    public string? PayerName { get; set; }

    [Column("cardholder_id")]
    [StringLength(35)]
    public string? CardholderId { get; set; }

    [Column("cardholder_first_name")]
    [StringLength(35)]
    public string? CardholderFirstName { get; set; }

    [Column("cardholder_last_name")]
    [StringLength(35)]
    public string? CardholderLastName { get; set; }

    [Column("cardholder_middle_name")]
    [StringLength(35)]
    public string? CardholderMiddleName { get; set; }

    [Column("cardholder_suffix")]
    [StringLength(10)]
    public string? CardholderSuffix { get; set; }

    [Column("cardholder_prefix")]
    [StringLength(10)]
    public string? CardholderPrefix { get; set; }

    [Column("group_id")]
    [StringLength(35)]
    public string? GroupId { get; set; }

    [Column("msg_typ")]
    [StringLength(8)]
    public string? MsgTyp { get; set; }
}
