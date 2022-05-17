using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Cluster.Type enumerated type defines the possible deployment types for a VCHA Cluster.
    /// </summary>
    public enum VcenterVchaClusterTypeEnumA
    {
        [EnumMember(Value = "AUTO")]
        AUTO = 1,
        [EnumMember(Value = "MANUAL")]
        MANUAL = 2,
    }
}
