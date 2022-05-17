using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// The enum defines values that indicate the state of Virtual Machine Health Monitoring. Health Monitoring uses the vmTools (guest) and application agent heartbeat modules. You can configure HA to respond to heartbeat failures of either one or both modules. You can also disable the HA response to heartbeat failures.
    /// </summary>
    public enum ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterHaFailuresAndResponsesVmMonitoringStateEnumType
    {
        [EnumMember(Value = "VM_MONITORING_DISABLED")]
        VMMONITORINGDISABLED = 1,
        [EnumMember(Value = "VM_MONITORING_ONLY")]
        VMMONITORINGONLY = 2,
        [EnumMember(Value = "VM_AND_APP_MONITORING")]
        VMANDAPPMONITORING = 3,
    }
}
