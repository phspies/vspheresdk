using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Services.CreateSpec.SourceType enumerated type specifies the source of truth the Attestation Service will use for its configuration.
    /// </summary>
    public enum VcenterTrustedInfrastructureTrustedClustersAttestationServicesCreateSpecSourceType
    {
        [EnumMember(Value = "SERVICE")]
        SERVICE = 1,
        [EnumMember(Value = "CLUSTER")]
        CLUSTER = 2,
    }
}
