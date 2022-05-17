using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// The ProactiveHAConfig.RemediationType enumerated type defines the types of remediation behaviours that can be configured.
    /// </summary>
    public enum ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterDrsProactiveHaconfigRemediationTypeEnum
    {
        [EnumMember(Value = "QUARANTINE_MODE")]
        QUARANTINEMODE = 1,
        [EnumMember(Value = "MAINTENANCE_MODE")]
        MAINTENANCEMODE = 2,
    }
}
