using System.Runtime.Serialization;

namespace vspheresdk.Hvc.Models.Enums
{
    /// <summary>
    /// The {@name Status} {@term enumerated type} defines valid sync status. *Warning:* This enumeration is available as Technology Preview. These are early access APIs provided to test, automate and provide feedback on the feature. Since this can change based on feedback, VMware does not guarantee backwards compatibility and recommends against using them in production environments. Some Technology Preview APIs might only be applicable to specific environments.
    /// </summary>
    public enum VcenterHvcLinksSyncProvidersStatusType
    {
        [EnumMember(Value = "SUCCEEDED")]
        SUCCEEDED = 1,
        [EnumMember(Value = "FAILED")]
        FAILED = 2,
        [EnumMember(Value = "NO_SYNC_FOUND")]
        NOSYNCFOUND = 3,
    }
}
