using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The ConnectionState enumerated type defines the valid states for a removable device that is configured to be connected.
    /// </summary>
    public enum VcenterVmHardwareConnectionStateType
    {
        [EnumMember(Value = "CONNECTED")]
        CONNECTED = 1,
        [EnumMember(Value = "RECOVERABLE_ERROR")]
        RECOVERABLEERROR = 2,
        [EnumMember(Value = "UNRECOVERABLE_ERROR")]
        UNRECOVERABLEERROR = 3,
        [EnumMember(Value = "NOT_CONNECTED")]
        NOTCONNECTED = 4,
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN = 5,
    }
}
