using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// The Job.ReturnStatus enumerated type defines the return type for the cancel operation. You specify the return status when you return the result of cancel job. See Job.ReturnResult.
    /// </summary>
    public enum ApplianceRecoveryBackupJobReturnStatusEnumTypeA
    {
        [EnumMember(Value = "FAIL")]
        FAIL = 1,
        [EnumMember(Value = "WARNING")]
        WARNING = 2,
        [EnumMember(Value = "OK")]
        OK = 3,
    }
}
