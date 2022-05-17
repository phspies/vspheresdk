using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// Hostname.MessageStatus enumerated type Individual test result
    /// </summary>
    public enum ApplianceNetworkingDnsHostnameMessageStatusType
    {
        [EnumMember(Value = "FAILURE")]
        Failure = 1,
        [EnumMember(Value = "SUCCESS")]
        Success = 2,
    }
}
