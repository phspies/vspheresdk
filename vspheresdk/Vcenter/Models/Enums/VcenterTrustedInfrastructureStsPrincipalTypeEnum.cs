using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The StsPrincipalType enum can be either users or groups.
    /// </summary>
    public enum VcenterTrustedInfrastructureStsPrincipalTypeEnum
    {
        [EnumMember(Value = "STS_USER")]
        STSUSER = 1,
        [EnumMember(Value = "STS_GROUP")]
        STSGROUP = 2,
    }
}
