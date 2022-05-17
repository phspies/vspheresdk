using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Policy.DiskPolicySpec enumerated type defines the choices for how to specify the policy to be associated with a virtual disk.
    /// </summary>
    public enum VcenterVmStoragePolicyDiskPolicySpecPolicyTypeEnumA
    {
        [EnumMember(Value = "USE_SPECIFIED_POLICY")]
        USESPECIFIEDPOLICY = 1,
        [EnumMember(Value = "USE_DEFAULT_POLICY")]
        USEDEFAULTPOLICY = 2,
    }
}
