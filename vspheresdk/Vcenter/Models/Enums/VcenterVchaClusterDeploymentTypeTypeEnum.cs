using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The DeploymentType.Type enumerated type defines the possible deployment types for a VCHA Cluster.
    /// </summary>
    public enum VcenterVchaClusterDeploymentTypeTypeEnum
    {
        [EnumMember(Value = "NONE")]
        NONE = 1,
        [EnumMember(Value = "AUTO")]
        AUTO = 2,
        [EnumMember(Value = "MANUAL")]
        MANUAL = 3,
    }
}
