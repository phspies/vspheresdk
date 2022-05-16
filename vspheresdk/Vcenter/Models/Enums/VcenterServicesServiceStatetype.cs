using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Service.State enumerated type defines valid Run State for services.
    /// </summary>
    public enum VcenterServicesServiceStateType
    {
        [EnumMember(Value = "STARTING")]
        STARTING = 1,
        [EnumMember(Value = "STOPPING")]
        STOPPING = 2,
        [EnumMember(Value = "STARTED")]
        STARTED = 3,
        [EnumMember(Value = "STOPPED")]
        STOPPED = 4,
    }
}
