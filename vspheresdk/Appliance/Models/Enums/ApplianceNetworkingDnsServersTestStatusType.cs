using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// Servers.TestStatus enumerated type Health indicator
    /// </summary>
    public enum ApplianceNetworkingDnsServersTestStatusType
    {
        [EnumMember(Value = "ORANGE")]
        Orange = 1,
        [EnumMember(Value = "GREEN")]
        Green = 2,
        [EnumMember(Value = "RED")]
        Red = 3,
    }
}
