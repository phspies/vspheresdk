using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Policy.VmHomePolicySpec.PolicyType enumerated type defines the choices for how to specify the policy to be associated with the virtual machine home&apos;s directory.
    /// </summary>
    public enum VcenterVmStoragePolicyVmHomePolicySpecPolicyTypeA
    {
        [EnumMember(Value = "USE_SPECIFIED_POLICY")]
        USESPECIFIEDPOLICY = 1,
        [EnumMember(Value = "USE_DEFAULT_POLICY")]
        USEDEFAULTPOLICY = 2,
    }
}
