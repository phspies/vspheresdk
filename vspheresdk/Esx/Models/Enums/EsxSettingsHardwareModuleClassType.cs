using System.Runtime.Serialization;

namespace vspheresdk.Esx.Models.Enums
{
    /// <summary>
    /// The {@name HardwareModuleClass} {@term structure} contains the module&apos;s source information.
    /// </summary>
    public enum EsxSettingsHardwareModuleClassType
    {
        [EnumMember(Value = "SYSTEM_BIOS")]
        SYSTEMBIOS = 1,
        [EnumMember(Value = "PCI_DEVICE")]
        PCIDEVICE = 2,
        [EnumMember(Value = "OTHER")]
        OTHER = 3,
    }
}
