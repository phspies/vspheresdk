using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Ethernet.EmulationType enumerated type defines the valid emulation types for a virtual Ethernet adapter.
    /// </summary>
    public enum VcenterVmHardwareEthernetEmulationTypeEnum
    {
        [EnumMember(Value = "E1000")]
        E1000 = 1,
        [EnumMember(Value = "E1000E")]
        E1000E = 2,
        [EnumMember(Value = "PCNET32")]
        PCNET32 = 3,
        [EnumMember(Value = "VMXNET")]
        VMXNET = 4,
        [EnumMember(Value = "VMXNET2")]
        VMXNET2 = 5,
        [EnumMember(Value = "VMXNET3")]
        VMXNET3 = 6,
    }
}
