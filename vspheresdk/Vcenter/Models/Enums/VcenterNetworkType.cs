using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// 
    /// </summary>
    public enum VcenterNetworkType
    {
        [EnumMember(Value = "STANDARD_PORTGROUP")]
        STANDARDPORTGROUP = 1,
        [EnumMember(Value = "DISTRIBUTED_PORTGROUP")]
        DISTRIBUTEDPORTGROUP = 2,
        [EnumMember(Value = "OPAQUE_NETWORK")]
        OPAQUENETWORK = 3,
    }
}
