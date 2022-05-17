using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// 
    /// </summary>
    public enum VcenterHostConnectionStateEnumTypeA
    {
        [EnumMember(Value = "CONNECTED")]
        CONNECTED = 1,
        [EnumMember(Value = "DISCONNECTED")]
        DISCONNECTED = 2,
        [EnumMember(Value = "NOT_RESPONDING")]
        NOTRESPONDING = 3,
    }
}
