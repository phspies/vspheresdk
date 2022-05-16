using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// Policy type for the deployed virtual machine&apos;s configuration and log files.
    /// </summary>
    public enum VcenterVmTemplateLibraryItemsDeploySpecVmHomeStoragePolicyType
    {
        [EnumMember(Value = "USE_SPECIFIED_POLICY")]
        USESPECIFIEDPOLICY = 1,
        [EnumMember(Value = "USE_SOURCE_POLICY")]
        USESOURCEPOLICY = 2,
    }
}
