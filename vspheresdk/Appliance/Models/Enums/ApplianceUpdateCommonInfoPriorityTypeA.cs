using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// The CommonInfo.Priority enumerated type defines the update installation priority recommendations.
    /// </summary>
    public enum ApplianceUpdateCommonInfoPriorityTypeA
    {
        [EnumMember(Value = "HIGH")]
        HIGH = 1,
        [EnumMember(Value = "MEDIUM")]
        MEDIUM = 2,
        [EnumMember(Value = "LOW")]
        LOW = 3,
    }
}
