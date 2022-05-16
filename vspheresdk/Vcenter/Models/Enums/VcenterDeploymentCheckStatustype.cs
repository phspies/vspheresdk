using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The CheckStatus enumerated type defines the status of the checks.
    /// </summary>
    public enum VcenterDeploymentCheckStatusType
    {
        [EnumMember(Value = "SUCCESS")]
        SUCCESS = 1,
        [EnumMember(Value = "FAILED")]
        FAILED = 2,
    }
}
