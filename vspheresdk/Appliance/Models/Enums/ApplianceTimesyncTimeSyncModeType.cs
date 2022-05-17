using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// The Timesync.TimeSyncMode enumerated type defines time synchronization modes
    /// </summary>
    public enum ApplianceTimesyncTimeSyncModeType
    {
        [EnumMember(Value = "DISABLED")]
        DISABLED = 1,
        [EnumMember(Value = "NTP")]
        NTP = 2,
        [EnumMember(Value = "HOST")]
        HOST = 3,
    }
}
