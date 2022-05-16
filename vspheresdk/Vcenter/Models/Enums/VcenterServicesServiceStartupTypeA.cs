using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Service.StartupType enumerated type defines valid Startup Type for vCenter Server services.
    /// </summary>
    public enum VcenterServicesServiceStartupTypeA
    {
        [EnumMember(Value = "MANUAL")]
        MANUAL = 1,
        [EnumMember(Value = "AUTOMATIC")]
        AUTOMATIC = 2,
        [EnumMember(Value = "DISABLED")]
        DISABLED = 3,
    }
}
