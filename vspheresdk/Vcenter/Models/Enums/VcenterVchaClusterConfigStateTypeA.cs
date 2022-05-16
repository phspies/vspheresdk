using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Cluster.ConfigState enumerated type defines the VCHA configuration state.
    /// </summary>
    public enum VcenterVchaClusterConfigStateTypeA
    {
        [EnumMember(Value = "CONFIGURED")]
        CONFIGURED = 1,
        [EnumMember(Value = "NOTCONFIGURED")]
        NOTCONFIGURED = 2,
        [EnumMember(Value = "INVALID")]
        INVALID = 3,
        [EnumMember(Value = "PREPARED")]
        PREPARED = 4,
    }
}
