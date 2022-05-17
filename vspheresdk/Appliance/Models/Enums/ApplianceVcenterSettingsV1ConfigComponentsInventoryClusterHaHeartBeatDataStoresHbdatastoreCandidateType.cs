using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// The policy to determine the candidates from which vCenter Server can choose heartbeat datastores.
    /// </summary>
    public enum ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterHaHeartBeatDataStoresHbdatastoreCandidateType
    {
        [EnumMember(Value = "USER_SELECTED_DS")]
        USERSELECTEDDS = 1,
        [EnumMember(Value = "ALL_FEASIBLE_DS")]
        ALLFEASIBLEDS = 2,
        [EnumMember(Value = "ALL_FEASIBLE_DS_WITH_USER_PREFERENCE")]
        ALLFEASIBLEDSWITHUSERPREFERENCE = 3,
    }
}
