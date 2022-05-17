using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// The Forwarding.ConnectionStatus.State enumerated type defines the state values that a remote logging server can be in.
    /// </summary>
    public enum ApplianceLoggingForwardingConnectionStatusStateType
    {
        [EnumMember(Value = "UP")]
        UP = 1,
        [EnumMember(Value = "DOWN")]
        DOWN = 2,
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN = 3,
    }
}
