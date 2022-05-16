using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Tools.ToolsInstallType enumerated type defines the installation type of the Tools in the guest operating system.
    /// </summary>
    public enum VcenterVmToolsToolsInstallType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN = 1,
        [EnumMember(Value = "MSI")]
        MSI = 2,
        [EnumMember(Value = "TAR")]
        TAR = 3,
        [EnumMember(Value = "OSP")]
        OSP = 4,
        [EnumMember(Value = "OPEN_VM_TOOLS")]
        OPENVMTOOLS = 5,
    }
}
