using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The NetworkType enumerated type defines the type of a vCenter Server network.
    /// </summary>
    public enum VcenterVchaNetworkType
    {
        [EnumMember(Value = "STANDARD_PORTGROUP")]
        STANDARDPORTGROUP = 1,
        [EnumMember(Value = "DISTRIBUTED_PORTGROUP")]
        DISTRIBUTEDPORTGROUP = 2,
    }
}
