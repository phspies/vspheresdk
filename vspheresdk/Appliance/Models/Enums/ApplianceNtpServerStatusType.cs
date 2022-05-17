using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// Ntp.ServerStatus enumerated type Status of server during test
    /// </summary>
    public enum ApplianceNtpServerStatusType
    {
        [EnumMember(Value = "SERVER_REACHABLE")]
        SERVERREACHABLE = 1,
        [EnumMember(Value = "SERVER_UNREACHABLE")]
        SERVERUNREACHABLE = 2,
    }
}
