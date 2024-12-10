using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("DosageForm", "ExtDrugDbId")]
[Table("dosage_form_ext_drug_db")]
public partial class DosageFormExtDrugDb
{
    [Key]
    [Column("dosage_form")]
    public int DosageForm { get; set; }

    [Key]
    [Column("ext_drug_db_id")]
    public int ExtDrugDbId { get; set; }

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

    [ForeignKey("DosageForm")]
    [InverseProperty("DosageFormExtDrugDb")]
    public virtual DosageForm DosageFormNavigation { get; set; } = null!;

    [ForeignKey("ExtDrugDbId")]
    [InverseProperty("DosageFormExtDrugDb")]
    public virtual ExtDrugDb ExtDrugDb { get; set; } = null!;
}
