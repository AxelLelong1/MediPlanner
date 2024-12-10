using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("CustFormId", "FormFieldId")]
[Table("ct_cust_form_fields")]
public partial class CtCustFormFields
{
    [Key]
    [Column("cust_form_id")]
    public int CustFormId { get; set; }

    [Key]
    [Column("form_field_id")]
    public int FormFieldId { get; set; }

    [Column("field_name")]
    [StringLength(55)]
    public string? FieldName { get; set; }

    [Column("field_outcomes_name")]
    [StringLength(55)]
    public string? FieldOutcomesName { get; set; }

    [Column("field_outcomes_desc")]
    [StringLength(255)]
    public string? FieldOutcomesDesc { get; set; }

    [Column("field_required_ind")]
    [StringLength(1)]
    public string? FieldRequiredInd { get; set; }

    [Column("field_data_source_sp_name")]
    [StringLength(125)]
    public string? FieldDataSourceSpName { get; set; }

    [Column("field_word_field_typ")]
    [StringLength(55)]
    public string? FieldWordFieldTyp { get; set; }

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
}
