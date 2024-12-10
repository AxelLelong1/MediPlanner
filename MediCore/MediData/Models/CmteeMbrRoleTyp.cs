using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("CmteeMbrRoleTyp1", "CultureCd")]
[Table("cmtee_mbr_role_typ")]
public partial class CmteeMbrRoleTyp
{
    [Key]
    [Column("cmtee_mbr_role_typ")]
    public int CmteeMbrRoleTyp1 { get; set; }

    [Key]
    [Column("culture_cd")]
    [StringLength(10)]
    public string CultureCd { get; set; } = null!;

    [Column("cmtee_mbr_role_typ_desc")]
    [StringLength(55)]
    public string? CmteeMbrRoleTypDesc { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(20)]
    public string? TransLogInstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
