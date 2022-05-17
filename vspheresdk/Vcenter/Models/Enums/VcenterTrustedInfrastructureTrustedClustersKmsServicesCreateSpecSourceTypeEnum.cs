using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Services.CreateSpec.SourceType enumerated type specifies source of truth the Key Provider Service will use for its configuration.
    /// </summary>
    public enum VcenterTrustedInfrastructureTrustedClustersKmsServicesCreateSpecSourceTypeEnum
    {
        [EnumMember(Value = "SERVICE")]
        SERVICE = 1,
        [EnumMember(Value = "CLUSTER")]
        CLUSTER = 2,
    }
}
