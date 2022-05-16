using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Parallel.BackingType enumerated type defines the valid backing types for a virtual parallel port.
    /// </summary>
    public enum VcenterVmHardwareParallelBackingTypeA
    {
        [EnumMember(Value = "FILE")]
        FILE = 1,
        [EnumMember(Value = "HOST_DEVICE")]
        HOSTDEVICE = 2,
    }
}
