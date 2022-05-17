using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// Identifies the network plugin that cluster networking functionalities for this vSphere Namespaces Cluster.
    /// </summary>
    public enum VcenterNamespaceManagementClustersNetworkProviderEnumType
    {
        [EnumMember(Value = "NSXT_CONTAINER_PLUGIN")]
        NSXTCONTAINERPLUGIN = 1,
        [EnumMember(Value = "VSPHERE_NETWORK")]
        VSPHERENETWORK = 2,
    }
}
