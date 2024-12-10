using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtQmDetailId")]
[Table("pt_qm_detail")]
public partial class PtQmDetail
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_qm_detail_id")]
    public int PtQmDetailId { get; set; }

    [Column("qmi_id")]
    public int QmiId { get; set; }

    [Column("qrda_cat_id")]
    public int QrdaCatId { get; set; }

    [Column("qm_detail_int_1")]
    public int? QmDetailInt1 { get; set; }

    [Column("qm_detail_int_2")]
    public int? QmDetailInt2 { get; set; }

    [Column("qm_detail_int_3")]
    public int? QmDetailInt3 { get; set; }

    [Column("qm_detail_int_4")]
    public int? QmDetailInt4 { get; set; }

    [Column("qm_detail_bigint_1")]
    public long? QmDetailBigint1 { get; set; }

    [Column("qm_detail_str_1")]
    [StringLength(50)]
    public string? QmDetailStr1 { get; set; }

    [Column("qm_detail_datetime_1", TypeName = "datetime")]
    public DateTime? QmDetailDatetime1 { get; set; }

    [Column("qm_value_set_code")]
    [StringLength(255)]
    public string QmValueSetCode { get; set; } = null!;

    [Column("qm_detail_code")]
    [StringLength(50)]
    public string QmDetailCode { get; set; } = null!;

    [Column("qm_detail_code_typ")]
    public int QmDetailCodeTyp { get; set; }

    [Column("qm_event_code_ind")]
    [StringLength(1)]
    public string? QmEventCodeInd { get; set; }

    [Column("not_done_ind")]
    [StringLength(1)]
    public string? NotDoneInd { get; set; }

    [Column("start_date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column("end_date", TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    [Column("result_code")]
    [StringLength(50)]
    public string? ResultCode { get; set; }

    [Column("result_value_set_code")]
    [StringLength(255)]
    public string? ResultValueSetCode { get; set; }

    [Column("result_code_typ")]
    public int? ResultCodeTyp { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("qm_resource_ser")]
    public long QmResourceSer { get; set; }

    [Column("stkh_id")]
    [StringLength(20)]
    public string StkhId { get; set; } = null!;

    [ForeignKey("PtId")]
    [InverseProperty("PtQmDetail")]
    public virtual Pt Pt { get; set; } = null!;

    [ForeignKey("QmiId")]
    [InverseProperty("PtQmDetail")]
    public virtual QmInstance Qmi { get; set; } = null!;

    [ForeignKey("QrdaCatId")]
    [InverseProperty("PtQmDetail")]
    public virtual QrdaCat QrdaCat { get; set; } = null!;
}
