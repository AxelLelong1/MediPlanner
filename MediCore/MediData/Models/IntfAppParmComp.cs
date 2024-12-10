using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("IntfAppParmId", "IntfAppParmCompId")]
[Table("intf_app_parm_comp")]
[Index("IntfAppParmFieldId", Name = "nc1_intf_app_parm_comp")]
[Index("IntfAppParmId", "FieldCompXrefId", Name = "nc2_intf_app_parm_comp")]
[Index("IntfAppParmFieldId", "IntfAppParmId", "IntfAppParmCompId", "IntfAppParmCondHeaderId", Name = "nc4_intf_app_parm_comp")]
public partial class IntfAppParmComp
{
    [Key]
    [Column("intf_app_parm_id")]
    [StringLength(10)]
    public string IntfAppParmId { get; set; } = null!;

    [Key]
    [Column("intf_app_parm_comp_id")]
    [StringLength(10)]
    public string IntfAppParmCompId { get; set; } = null!;

    [Column("intf_app_parm_field_id")]
    [StringLength(10)]
    public string IntfAppParmFieldId { get; set; } = null!;

    [Column("field_comp_xref_id")]
    [StringLength(10)]
    public string? FieldCompXrefId { get; set; }

    [Column("err_severity")]
    public int? ErrSeverity { get; set; }

    [Column("dflt_map_severity")]
    public int? DfltMapSeverity { get; set; }

    [Column("ovride_ind")]
    [StringLength(1)]
    public string OvrideInd { get; set; } = null!;

    [Column("prepost_ind")]
    [StringLength(1)]
    public string PrepostInd { get; set; } = null!;

    [Column("prcs_cd")]
    [StringLength(1)]
    public string PrcsCd { get; set; } = null!;

    [Column("doc_desc")]
    [StringLength(255)]
    public string? DocDesc { get; set; }

    [Column("map_active_ind")]
    [StringLength(1)]
    public string MapActiveInd { get; set; } = null!;

    [Column("map_dflt_val")]
    [StringLength(60)]
    public string? MapDfltVal { get; set; }

    [Column("a_ref_id")]
    [StringLength(15)]
    public string? ARefId { get; set; }

    [Column("a_inst_id")]
    [StringLength(30)]
    public string? AInstId { get; set; }

    [Column("b_ref_id")]
    [StringLength(15)]
    public string? BRefId { get; set; }

    [Column("b_inst_id")]
    [StringLength(30)]
    public string? BInstId { get; set; }

    [Column("base_tstamp", TypeName = "datetime")]
    public DateTime BaseTstamp { get; set; }

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

    [Column("def_typ")]
    [StringLength(1)]
    public string? DefTyp { get; set; }

    [Column("data_typ")]
    [StringLength(3)]
    public string? DataTyp { get; set; }

    [Column("comp_name")]
    [StringLength(30)]
    public string? CompName { get; set; }

    [Column("comp_no")]
    public int? CompNo { get; set; }

    [Column("comp_data_typ")]
    [StringLength(3)]
    public string? CompDataTyp { get; set; }

    [Column("sub_comp_no")]
    public int? SubCompNo { get; set; }

    [Column("sub_comp_name")]
    [StringLength(30)]
    public string? SubCompName { get; set; }

    [Column("sub_comp_data_typ")]
    [StringLength(3)]
    public string? SubCompDataTyp { get; set; }

    [Column("comp_desc")]
    [StringLength(255)]
    public string? CompDesc { get; set; }

    [Column("sub_comp_desc")]
    [StringLength(255)]
    public string? SubCompDesc { get; set; }

    [Column("data_format")]
    [StringLength(60)]
    public string? DataFormat { get; set; }

    [Column("data_typ_no")]
    public int? DataTypNo { get; set; }

    [Column("case_ind")]
    [StringLength(1)]
    public string? CaseInd { get; set; }

    [Column("inbnd_prcs_cd")]
    [StringLength(1)]
    public string? InbndPrcsCd { get; set; }

    [Column("outbnd_prcs_cd")]
    [StringLength(1)]
    public string? OutbndPrcsCd { get; set; }

    [Column("custom_ind")]
    [StringLength(1)]
    public string? CustomInd { get; set; }

    [Column("intf_app_parm_cond_header_id")]
    [StringLength(10)]
    public string? IntfAppParmCondHeaderId { get; set; }

    [ForeignKey("IntfAppParmId")]
    [InverseProperty("IntfAppParmComp")]
    public virtual IntfAppParm IntfAppParm { get; set; } = null!;

    [ForeignKey("IntfAppParmId, IntfAppParmFieldId")]
    [InverseProperty("IntfAppParmComp")]
    public virtual IntfAppParmField IntfAppParmField { get; set; } = null!;

    [InverseProperty("IntfAppParmComp")]
    public virtual ICollection<IntfAppParmTrnsltnFld> IntfAppParmTrnsltnFld { get; set; } = new List<IntfAppParmTrnsltnFld>();
}
