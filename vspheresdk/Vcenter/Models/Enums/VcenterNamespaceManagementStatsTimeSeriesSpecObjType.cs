using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// Type of statistics object that this request is operating on.
    /// </summary>
    public enum VcenterNamespaceManagementStatsTimeSeriesSpecObjType
    {
        [EnumMember(Value = "CLUSTER")]
        CLUSTER = 1,
        [EnumMember(Value = "NAMESPACE")]
        NAMESPACE = 2,
        [EnumMember(Value = "POD")]
        POD = 3,
    }
}
