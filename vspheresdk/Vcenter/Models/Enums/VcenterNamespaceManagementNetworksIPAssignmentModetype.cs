using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Networks.IPAssignmentMode enumerated type defines various IP address assignment modes.
    /// </summary>
    public enum VcenterNamespaceManagementNetworksIpassignmentModeType
    {
        [EnumMember(Value = "DHCP")]
        DHCP = 1,
        [EnumMember(Value = "STATICRANGE")]
        STATICRANGE = 2,
    }
}
