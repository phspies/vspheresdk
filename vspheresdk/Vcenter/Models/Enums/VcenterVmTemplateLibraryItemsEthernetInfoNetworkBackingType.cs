using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The {@name NetworkBackingType} {@term enumerated type} defines valid network backing types for a virtual Ethernet adapter.
    /// </summary>
    public enum VcenterVmTemplateLibraryItemsEthernetInfoNetworkBackingType
    {
        [EnumMember(Value = "STANDARD_PORTGROUP")]
        STANDARDPORTGROUP = 1,
        [EnumMember(Value = "HOST_DEVICE")]
        HOSTDEVICE = 2,
        [EnumMember(Value = "DISTRIBUTED_PORTGROUP")]
        DISTRIBUTEDPORTGROUP = 3,
        [EnumMember(Value = "OPAQUE_NETWORK")]
        OPAQUENETWORK = 4,
    }
}
