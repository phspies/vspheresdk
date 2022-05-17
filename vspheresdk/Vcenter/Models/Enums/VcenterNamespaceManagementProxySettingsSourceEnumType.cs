using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The settings can be inherited from the vCenter settings, so the cluster settings will be synced. The settings can be applied directly on the cluster level, or the cluster can be configured not to use a proxy.
    /// </summary>
    public enum VcenterNamespaceManagementProxySettingsSourceEnumType
    {
        [EnumMember(Value = "VC_INHERITED")]
        VCINHERITED = 1,
        [EnumMember(Value = "CLUSTER_CONFIGURED")]
        CLUSTERCONFIGURED = 2,
        [EnumMember(Value = "NONE")]
        NONE = 3,
    }
}
