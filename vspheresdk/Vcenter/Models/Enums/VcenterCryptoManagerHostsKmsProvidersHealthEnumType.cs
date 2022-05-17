using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// 
    /// </summary>
    public enum VcenterCryptoManagerHostsKmsProvidersHealthEnumType
    {
        [EnumMember(Value = "NONE")]
        NONE = 1,
        [EnumMember(Value = "OK")]
        OK = 2,
        [EnumMember(Value = "WARNING")]
        WARNING = 3,
        [EnumMember(Value = "ERROR")]
        ERROR = 4,
    }
}
