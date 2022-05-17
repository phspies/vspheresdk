using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// The Update.State enumerated type defines the various states the appliance update can be in.
    /// </summary>
    public enum ApplianceUpdateStateTypeA
    {
        [EnumMember(Value = "UP_TO_DATE")]
        UPTODATE = 1,
        [EnumMember(Value = "UPDATES_PENDING")]
        UPDATESPENDING = 2,
        [EnumMember(Value = "STAGE_IN_PROGRESS")]
        STAGEINPROGRESS = 3,
        [EnumMember(Value = "INSTALL_IN_PROGRESS")]
        INSTALLINPROGRESS = 4,
        [EnumMember(Value = "INSTALL_FAILED")]
        INSTALLFAILED = 5,
        [EnumMember(Value = "ROLLBACK_IN_PROGRESS")]
        ROLLBACKINPROGRESS = 6,
    }
}
