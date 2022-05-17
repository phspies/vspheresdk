using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// Hostname.TestStatus enumerated type Health indicator
    /// </summary>
    public enum ApplianceNetworkingDnsHostnameTestStatusEnumTypeA
    {
        [EnumMember(Value = "ORANGE")]
        Orange = 1,
        [EnumMember(Value = "GREEN")]
        Green = 2,
        [EnumMember(Value = "RED")]
        Red = 3,
    }
}
