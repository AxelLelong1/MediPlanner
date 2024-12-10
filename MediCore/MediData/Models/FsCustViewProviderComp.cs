using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "Userid", "FsCustViewId", "FsDataTyp", "CompName")]
[Table("fs_cust_view_provider_comp")]
public partial class FsCustViewProviderComp
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("userid")]
    [StringLength(255)]
    public string Userid { get; set; } = null!;

    [Key]
    [Column("fs_cust_view_id")]
    public int FsCustViewId { get; set; }

    [Key]
    [Column("fs_data_typ")]
    [StringLength(25)]
    public string FsDataTyp { get; set; } = null!;

    [Key]
    [Column("comp_name")]
    [StringLength(50)]
    public string CompName { get; set; } = null!;

    [Column("typ_of_test")]
    [StringLength(20)]
    public string? TypOfTest { get; set; }

    [Column("test_comp_name")]
    [StringLength(30)]
    public string? TestCompName { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string TransLogMuserid { get; set; } = null!;

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string TransLogMinstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("fs_fcn_id")]
    public int? FsFcnId { get; set; }
}
