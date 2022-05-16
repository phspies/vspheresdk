using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// 
    /// </summary>
    public enum VcenterTrustedInfrastructureTrustAuthorityClustersStateType
    {
        [EnumMember(Value = "ENABLE")]
        ENABLE = 1,
        [EnumMember(Value = "DISABLE")]
        DISABLE = 2,
    }
}
