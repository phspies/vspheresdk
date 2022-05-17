using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Serial.BackingType enumerated type defines the valid backing types for a virtual serial port.
    /// </summary>
    public enum VcenterVmHardwareSerialBackingTypeEnumA
    {
        [EnumMember(Value = "FILE")]
        FILE = 1,
        [EnumMember(Value = "HOST_DEVICE")]
        HOSTDEVICE = 2,
        [EnumMember(Value = "PIPE_SERVER")]
        PIPESERVER = 3,
        [EnumMember(Value = "PIPE_CLIENT")]
        PIPECLIENT = 4,
        [EnumMember(Value = "NETWORK_SERVER")]
        NETWORKSERVER = 5,
        [EnumMember(Value = "NETWORK_CLIENT")]
        NETWORKCLIENT = 6,
    }
}
