using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// Policy type for the virtual machine template&apos;s configuration and log files.
    /// </summary>
    public enum VcenterVmTemplateLibraryItemsCreateSpecVmHomeStoragePolicyTypeEnum
    {
        [EnumMember(Value = "USE_SPECIFIED_POLICY")]
        USESPECIFIEDPOLICY = 1,
    }
}
