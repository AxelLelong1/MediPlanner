﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("SnomedTypCd", "XrefSnomedCdValue")]
[Table("xref_snomed_cd")]
public partial class XrefSnomedCd
{
    [Key]
    [Column("snomed_typ_cd")]
    public int SnomedTypCd { get; set; }

    [Key]
    [Column("xref_snomed_cd_value")]
    [StringLength(20)]
    public string XrefSnomedCdValue { get; set; } = null!;

    [Column("snomed_code_value")]
    public int SnomedCodeValue { get; set; }

    [Column("snomed_description")]
    [StringLength(280)]
    public string SnomedDescription { get; set; } = null!;

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

    [ForeignKey("SnomedTypCd")]
    [InverseProperty("XrefSnomedCd")]
    public virtual XrefSnomedTyp SnomedTypCdNavigation { get; set; } = null!;
}
