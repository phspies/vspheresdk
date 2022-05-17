using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// The Service.StartupType enumerated type defines valid Startup Type for services managed by vMon.
    /// </summary>
    public enum ApplianceVmonServiceStartupType
    {
        [EnumMember(Value = "MANUAL")]
        MANUAL = 1,
        [EnumMember(Value = "AUTOMATIC")]
        AUTOMATIC = 2,
        [EnumMember(Value = "DISABLED")]
        DISABLED = 3,
    }
}
