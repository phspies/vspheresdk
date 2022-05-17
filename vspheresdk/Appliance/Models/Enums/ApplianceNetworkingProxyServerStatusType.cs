using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// Proxy.ServerStatus enumerated type defines the status of the server associated with the test run.
    /// </summary>
    public enum ApplianceNetworkingProxyServerStatusType
    {
        [EnumMember(Value = "SERVER_REACHABLE")]
        SERVERREACHABLE = 1,
        [EnumMember(Value = "SERVER_UNREACHABLE")]
        SERVERUNREACHABLE = 2,
    }
}
