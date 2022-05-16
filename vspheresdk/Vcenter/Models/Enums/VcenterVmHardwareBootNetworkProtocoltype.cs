using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Boot.NetworkProtocol enumerated type defines the valid network boot protocols supported when booting a virtual machine with EFI firmware over the network.
    /// </summary>
    public enum VcenterVmHardwareBootNetworkProtocolType
    {
        [EnumMember(Value = "IPV4")]
        IPV4 = 1,
        [EnumMember(Value = "IPV6")]
        IPV6 = 2,
    }
}
