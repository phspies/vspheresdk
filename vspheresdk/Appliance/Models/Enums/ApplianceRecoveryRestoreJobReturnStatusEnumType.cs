using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// Job.ReturnStatus enumerated type Defines the state of precheck
    /// </summary>
    public enum ApplianceRecoveryRestoreJobReturnStatusEnumType
    {
        [EnumMember(Value = "FAIL")]
        FAIL = 1,
        [EnumMember(Value = "WARNING")]
        WARNING = 2,
        [EnumMember(Value = "OK")]
        OK = 3,
    }
}
