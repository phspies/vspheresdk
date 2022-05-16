using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Providers.KeyServerUpdateSpec.Type enumerated type list the key server types.
    /// </summary>
    public enum VcenterTrustedInfrastructureTrustAuthorityClustersKmsProvidersKeyServerUpdateSpecType
    {
        [EnumMember(Value = "KMIP")]
        KMIP = 1,
    }
}
