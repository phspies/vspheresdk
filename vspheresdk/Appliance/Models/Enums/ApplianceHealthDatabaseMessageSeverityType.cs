using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// The MessageSeverity enumerated type defines the levels of severity for a message.
    /// </summary>
    public enum ApplianceHealthDatabaseMessageSeverityType
    {
        [EnumMember(Value = "ERROR")]
        ERROR = 1,
        [EnumMember(Value = "WARNING")]
        WARNING = 2,
    }
}
