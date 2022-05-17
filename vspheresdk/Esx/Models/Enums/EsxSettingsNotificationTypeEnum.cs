using System.Runtime.Serialization;

namespace vspheresdk.Esx.Models.Enums
{
    /// <summary>
    /// The (@name Type} {@term enumerated type} contains the possible different types of notification.
    /// </summary>
    public enum EsxSettingsNotificationTypeEnum
    {
        [EnumMember(Value = "INFO")]
        INFO = 1,
        [EnumMember(Value = "WARNING")]
        WARNING = 2,
        [EnumMember(Value = "ERROR")]
        ERROR = 3,
    }
}
