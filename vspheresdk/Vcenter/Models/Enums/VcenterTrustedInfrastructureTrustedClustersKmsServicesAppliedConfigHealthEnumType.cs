using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The ServicesAppliedConfig.Health enumerated type is an indicator for the consistency of the applied Key Provider Service configuration in a cluster with respect to the desired state.
    /// </summary>
    public enum VcenterTrustedInfrastructureTrustedClustersKmsServicesAppliedConfigHealthEnumType
    {
        [EnumMember(Value = "NONE")]
        NONE = 1,
        [EnumMember(Value = "OK")]
        OK = 2,
        [EnumMember(Value = "ERROR")]
        ERROR = 3,
    }
}
