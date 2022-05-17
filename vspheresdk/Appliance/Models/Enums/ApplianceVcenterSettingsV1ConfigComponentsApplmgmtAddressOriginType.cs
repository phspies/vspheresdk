using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// The Address.Origin enumerated type defines IPv6 address origin values.
    /// </summary>
    public enum ApplianceVcenterSettingsV1ConfigComponentsApplmgmtAddressOriginType
    {
        [EnumMember(Value = "DHCP")]
        DHCP = 1,
        [EnumMember(Value = "RANDOM")]
        RANDOM = 2,
        [EnumMember(Value = "MANUAL")]
        MANUAL = 3,
        [EnumMember(Value = "LINKLAYER")]
        LINKLAYER = 4,
        [EnumMember(Value = "OTHER")]
        OTHER = 5,
    }
}
