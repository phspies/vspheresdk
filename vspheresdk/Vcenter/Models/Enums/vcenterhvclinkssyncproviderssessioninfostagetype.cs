using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The {@name Stage} {@term structure} defines the different stages of Sync. *Warning:* This enumeration is available as Technology Preview. These are early access APIs provided to test, automate and provide feedback on the feature. Since this can change based on feedback, VMware does not guarantee backwards compatibility and recommends against using them in production environments. Some Technology Preview APIs might only be applicable to specific environments.
    /// </summary>
    public enum VcenterHvcLinksSyncProvidersSessionInfoStageType
    {
        [EnumMember(Value = "CHANGE_DETECTION")]
        CHANGEDETECTION = 1,
        [EnumMember(Value = "CHANGE_ENUMERATION")]
        CHANGEENUMERATION = 2,
        [EnumMember(Value = "CHANGE_APPLICATION")]
        CHANGEAPPLICATION = 3,
        [EnumMember(Value = "COMPLETED")]
        COMPLETED = 4,
        [EnumMember(Value = "FAILED")]
        FAILED = 5,
        [EnumMember(Value = "WAITING")]
        WAITING = 6,
    }
}
