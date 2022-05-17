using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// Backup.ReturnStatus enumerated type Defines the state of precheck
    /// </summary>
    public enum ApplianceRecoveryBackupReturnStatusEnumType
    {
        [EnumMember(Value = "FAIL")]
        FAIL = 1,
        [EnumMember(Value = "WARNING")]
        WARNING = 2,
        [EnumMember(Value = "OK")]
        OK = 3,
    }
}
