using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// The Job.Status enumerated type defines the status values that can be reported for an operation.
    /// </summary>
    public enum ApplianceRecoveryReconciliationJobStatusEnumType
    {
        [EnumMember(Value = "NONE")]
        NONE = 1,
        [EnumMember(Value = "RUNNING")]
        RUNNING = 2,
        [EnumMember(Value = "SUCCEEDED")]
        SUCCEEDED = 3,
        [EnumMember(Value = "FAILED")]
        FAILED = 4,
    }
}
