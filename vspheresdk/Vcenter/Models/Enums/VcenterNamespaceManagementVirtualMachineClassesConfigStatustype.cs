using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// ConfigStatus represents the config status of the VM class.
    /// </summary>
    public enum VcenterNamespaceManagementVirtualMachineClassesConfigStatusType
    {
        [EnumMember(Value = "READY")]
        READY = 1,
        [EnumMember(Value = "REMOVING")]
        REMOVING = 2,
    }
}
