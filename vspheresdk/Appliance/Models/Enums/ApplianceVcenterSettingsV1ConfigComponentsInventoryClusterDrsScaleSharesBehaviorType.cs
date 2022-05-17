using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterDrsScaleSharesBehaviorType
    {
        [EnumMember(Value = "DISABLED")]
        DISABLED = 1,
        [EnumMember(Value = "SCALE_CPU_AND_MEMORY_SHARES")]
        SCALECPUANDMEMORYSHARES = 2,
    }
}
