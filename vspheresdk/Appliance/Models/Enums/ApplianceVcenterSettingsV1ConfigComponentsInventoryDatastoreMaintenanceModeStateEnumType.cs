using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// The MaintenanceModeState enumerated type defines the maintenance mode states of the datastore.
    /// </summary>
    public enum ApplianceVcenterSettingsV1ConfigComponentsInventoryDatastoreMaintenanceModeStateEnumType
    {
        [EnumMember(Value = "NORMAL")]
        NORMAL = 1,
        [EnumMember(Value = "ENTERING_MAINTENANCE")]
        ENTERINGMAINTENANCE = 2,
        [EnumMember(Value = "IN_MAINTENANCE")]
        INMAINTENANCE = 3,
    }
}
