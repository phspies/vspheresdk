using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// Identifies the network plugin that networking functionalities for this vSphere Namespace.
    /// </summary>
    public enum VcenterNamespacesInstancesNetworkProviderType
    {
        [EnumMember(Value = "NSXT_CONTAINER_PLUGIN")]
        NSXTCONTAINERPLUGIN = 1,
        [EnumMember(Value = "VSPHERE_NETWORK")]
        VSPHERENETWORK = 2,
    }
}
