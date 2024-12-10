﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("Hl7PtClsTypInstId", "Hl7PtClsTyp1")]
[Table("hl7_pt_cls_typ")]
public partial class Hl7PtClsTyp
{
    [Key]
    [Column("hl7_pt_cls_typ_inst_id")]
    [StringLength(30)]
    public string Hl7PtClsTypInstId { get; set; } = null!;

    [Key]
    [Column("hl7_pt_cls_typ")]
    public int Hl7PtClsTyp1 { get; set; }

    [Column("hl7_pt_cls_typ_abbr")]
    [StringLength(10)]
    public string Hl7PtClsTypAbbr { get; set; } = null!;

    [Column("hl7_pt_cls_typ_desc")]
    [StringLength(255)]
    public string Hl7PtClsTypDesc { get; set; } = null!;

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string ValidEntryInd { get; set; } = null!;

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

    [InverseProperty("Hl7PtClsTypNavigation")]
    public virtual ICollection<BillAcct> BillAcct { get; set; } = new List<BillAcct>();
}