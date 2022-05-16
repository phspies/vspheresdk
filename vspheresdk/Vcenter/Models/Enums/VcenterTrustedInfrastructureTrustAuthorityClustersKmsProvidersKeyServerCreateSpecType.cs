using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Providers.KeyServerCreateSpec.Type enumerated type lists the key server types.
    /// </summary>
    public enum VcenterTrustedInfrastructureTrustAuthorityClustersKmsProvidersKeyServerCreateSpecType
    {
        [EnumMember(Value = "KMIP")]
        KMIP = 1,
    }
}
