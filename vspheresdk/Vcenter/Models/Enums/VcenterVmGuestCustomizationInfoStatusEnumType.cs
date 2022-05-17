using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Customization.Info.Status enumerated type defines the status values that can be reported for the customization operation.
    /// </summary>
    public enum VcenterVmGuestCustomizationInfoStatusEnumType
    {
        [EnumMember(Value = "IDLE")]
        IDLE = 1,
        [EnumMember(Value = "PENDING")]
        PENDING = 2,
        [EnumMember(Value = "RUNNING")]
        RUNNING = 3,
        [EnumMember(Value = "SUCCEEDED")]
        SUCCEEDED = 4,
        [EnumMember(Value = "FAILED")]
        FAILED = 5,
    }
}
