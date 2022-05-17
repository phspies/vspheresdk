using System.Runtime.Serialization;

namespace vspheresdk.Esx.Models.Enums
{
    /// <summary>
    /// The {@name PreRemediationPowerAction} {@term enumerated type} defines the possible actions to be taken, before entering maintenance mode.
    /// </summary>
    public enum EsxSettingsClustersPoliciesApplyEffectiveEffectivePolicySpecPreRemediationPowerActionType
    {
        [EnumMember(Value = "POWER_OFF_VMS")]
        POWEROFFVMS = 1,
        [EnumMember(Value = "SUSPEND_VMS")]
        SUSPENDVMS = 2,
        [EnumMember(Value = "DO_NOT_CHANGE_VMS_POWER_STATE")]
        DONOTCHANGEVMSPOWERSTATE = 3,
        [EnumMember(Value = "SUSPEND_VMS_TO_MEMORY")]
        SUSPENDVMSTOMEMORY = 4,
    }
}
