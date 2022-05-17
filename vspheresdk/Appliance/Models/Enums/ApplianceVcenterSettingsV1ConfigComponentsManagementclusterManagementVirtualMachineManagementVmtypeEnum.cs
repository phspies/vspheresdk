using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// The ManagementVirtualMachine.ManagementVMType enumerated type defines the type of management virtual machine. Warning: This enumeration is available as Technology Preview. These are early access APIs provided to test, automate and provide feedback on the feature. Since this can change based on feedback, VMware does not guarantee backwards compatibility and recommends against using them in production environments. Some Technology Preview APIs might only be applicable to specific environments.
    /// </summary>
    public enum ApplianceVcenterSettingsV1ConfigComponentsManagementclusterManagementVirtualMachineManagementVmtypeEnum
    {
        [EnumMember(Value = "VCENTER")]
        VCENTER = 1,
        [EnumMember(Value = "CLOUD_GATEWAY")]
        CLOUDGATEWAY = 2,
    }
}
