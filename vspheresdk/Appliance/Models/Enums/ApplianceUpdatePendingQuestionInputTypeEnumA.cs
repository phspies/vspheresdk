using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// The Pending.Question.InputType enumerated type defines representation of field fields in GUI or CLI
    /// </summary>
    public enum ApplianceUpdatePendingQuestionInputTypeEnumA
    {
        [EnumMember(Value = "PLAIN_TEXT")]
        PLAINTEXT = 1,
        [EnumMember(Value = "BOOLEAN")]
        BOOLEAN = 2,
        [EnumMember(Value = "PASSWORD")]
        PASSWORD = 3,
    }
}
