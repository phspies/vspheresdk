using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Instances.Message.MessageSeverity enumerated type represents the severity of the message.
    /// </summary>
    public enum VcenterNamespacesInstancesMessageMessageSeverityEnumType
    {
        [EnumMember(Value = "INFO")]
        INFO = 1,
        [EnumMember(Value = "WARNING")]
        WARNING = 2,
        [EnumMember(Value = "ERROR")]
        ERROR = 3,
    }
}
