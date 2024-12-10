using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("HospitalSer", "DepartmentId", Name = "XAK1Department", IsUnique = true)]
public partial class Department
{
    [Key]
    public long DepartmentSer { get; set; }

    public long HospitalSer { get; set; }

    [StringLength(16)]
    public string DepartmentId { get; set; } = null!;

    [StringLength(64)]
    public string? DepartmentName { get; set; }

    [StringLength(16)]
    public string ObjectStatus { get; set; } = null!;

    [StringLength(254)]
    public string? Comment { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("DepartmentSerNavigation")]
    public virtual ICollection<AccountBillingCode> AccountBillingCode { get; set; } = new List<AccountBillingCode>();

    [InverseProperty("DepartmentSerNavigation")]
    public virtual ICollection<ActInstProcCode> ActInstProcCode { get; set; } = new List<ActInstProcCode>();

    [InverseProperty("DepartmentSerNavigation")]
    public virtual ICollection<ActivityCapture> ActivityCapture { get; set; } = new List<ActivityCapture>();

    [InverseProperty("DepartmentSerNavigation")]
    public virtual ICollection<ActivityCategory> ActivityCategory { get; set; } = new List<ActivityCategory>();

    [InverseProperty("DepartmentSerNavigation")]
    public virtual ICollection<ActivityInstance> ActivityInstance { get; set; } = new List<ActivityInstance>();

    [InverseProperty("DepartmentSerNavigation")]
    public virtual ICollection<ActivityPttrn> ActivityPttrn { get; set; } = new List<ActivityPttrn>();

    [InverseProperty("DepartmentSerNavigation")]
    public virtual ICollection<BillSysChrgWrk> BillSysChrgWrk { get; set; } = new List<BillSysChrgWrk>();

    [InverseProperty("DepartmentSerNavigation")]
    public virtual ICollection<BillSysHospDeptActivity> BillSysHospDeptActivity { get; set; } = new List<BillSysHospDeptActivity>();

    [InverseProperty("DepartmentSerNavigation")]
    public virtual ICollection<BillSysPendingTransactions> BillSysPendingTransactions { get; set; } = new List<BillSysPendingTransactions>();

    [InverseProperty("DepartmentSerNavigation")]
    public virtual ICollection<ChecklistGroup> ChecklistGroup { get; set; } = new List<ChecklistGroup>();

    [InverseProperty("DepartmentSerNavigation")]
    public virtual ICollection<ChecklistItem> ChecklistItem { get; set; } = new List<ChecklistItem>();

    [InverseProperty("DepartmentSerNavigation")]
    public virtual ICollection<ConfigurationSet> ConfigurationSet { get; set; } = new List<ConfigurationSet>();

    [InverseProperty("DepartmentSerNavigation")]
    public virtual ICollection<DepartmentPttrnDetails> DepartmentPttrnDetails { get; set; } = new List<DepartmentPttrnDetails>();

    [InverseProperty("DepartmentSerNavigation")]
    public virtual ICollection<DeptGrpAssociation> DeptGrpAssociation { get; set; } = new List<DeptGrpAssociation>();

    [ForeignKey("HospitalSer")]
    [InverseProperty("Department")]
    public virtual Hospital HospitalSerNavigation { get; set; } = null!;

    [InverseProperty("CtrDepartmentSerNavigation")]
    public virtual ICollection<InSightiveSimplifiedHospDeptConfigurationTb> InSightiveSimplifiedHospDeptConfigurationTb { get; set; } = new List<InSightiveSimplifiedHospDeptConfigurationTb>();

    [InverseProperty("DepartmentSerNavigation")]
    public virtual ICollection<PatientDepartment> PatientDepartment { get; set; } = new List<PatientDepartment>();

    [InverseProperty("DepartmentSerNavigation")]
    public virtual ICollection<ProcedureCode> ProcedureCode { get; set; } = new List<ProcedureCode>();

    [InverseProperty("DepartmentSerNavigation")]
    public virtual ICollection<ResourceDepartment> ResourceDepartment { get; set; } = new List<ResourceDepartment>();

    [InverseProperty("DepartmentSerNavigation")]
    public virtual ICollection<ResourceGroup> ResourceGroup { get; set; } = new List<ResourceGroup>();

    [InverseProperty("DepartmentSerNavigation")]
    public virtual ICollection<ScheduleHoliday> ScheduleHoliday { get; set; } = new List<ScheduleHoliday>();

    [InverseProperty("DepartmentSerNavigation")]
    public virtual ICollection<Template> Template { get; set; } = new List<Template>();
}
