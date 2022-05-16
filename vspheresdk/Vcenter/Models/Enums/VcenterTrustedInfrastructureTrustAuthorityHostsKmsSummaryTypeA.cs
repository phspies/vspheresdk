using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The connection information could include the certificates or be a shorter summary.
    /// </summary>
    public enum VcenterTrustedInfrastructureTrustAuthorityHostsKmsSummaryTypeA
    {
        [EnumMember(Value = "FULL")]
        FULL = 1,
        [EnumMember(Value = "NORMAL")]
        NORMAL = 2,
        [EnumMember(Value = "BRIEF")]
        BRIEF = 3,
    }
}
