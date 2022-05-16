using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The WindowsConfiguration.RebootOption enumerated type specifies what should be done to the guest after the customization.
    /// </summary>
    public enum VcenterGuestWindowsConfigurationRebootOptionTypeA
    {
        [EnumMember(Value = "REBOOT")]
        REBOOT = 1,
        [EnumMember(Value = "NO_REBOOT")]
        NOREBOOT = 2,
        [EnumMember(Value = "SHUTDOWN")]
        SHUTDOWN = 3,
    }
}
