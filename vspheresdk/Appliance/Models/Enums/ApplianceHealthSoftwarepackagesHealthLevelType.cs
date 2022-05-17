using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// Softwarepackages.HealthLevel enumerated type Defines health levels.
    /// </summary>
    public enum ApplianceHealthSoftwarepackagesHealthLevelType
    {
        [EnumMember(Value = "ORANGE")]
        Orange = 1,
        [EnumMember(Value = "GRAY")]
        Gray = 2,
        [EnumMember(Value = "GREEN")]
        Green = 3,
        [EnumMember(Value = "RED")]
        Red = 4,
        [EnumMember(Value = "YELLOW")]
        Yellow = 5,
    }
}
