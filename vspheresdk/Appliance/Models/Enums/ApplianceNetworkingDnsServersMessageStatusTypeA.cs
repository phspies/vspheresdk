using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// Servers.MessageStatus enumerated type Individual test result
    /// </summary>
    public enum ApplianceNetworkingDnsServersMessageStatusTypeA
    {
        [EnumMember(Value = "FAILURE")]
        Failure = 1,
        [EnumMember(Value = "SUCCESS")]
        Success = 2,
    }
}
