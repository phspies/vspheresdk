using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The {@name MacAddressType} {@term enumerated type} defines the valid MAC address origins for a virtual Ethernet adapter.
    /// </summary>
    public enum VcenterVmTemplateLibraryItemsEthernetInfoMacAddressTypeEnumA
    {
        [EnumMember(Value = "MANUAL")]
        MANUAL = 1,
        [EnumMember(Value = "GENERATED")]
        GENERATED = 2,
        [EnumMember(Value = "ASSIGNED")]
        ASSIGNED = 3,
    }
}
