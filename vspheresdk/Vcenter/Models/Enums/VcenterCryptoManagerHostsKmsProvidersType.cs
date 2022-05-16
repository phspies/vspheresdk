using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// 
    /// </summary>
    public enum VcenterCryptoManagerHostsKmsProvidersType
    {
        [EnumMember(Value = "NATIVE")]
        NATIVE = 1,
        [EnumMember(Value = "TRUST_AUTHORITY")]
        TRUSTAUTHORITY = 2,
    }
}
