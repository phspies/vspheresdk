using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The ApplianceSize enumerated type defines the vCenter Server Appliance sizes.
    /// </summary>
    public enum VcenterDeploymentApplianceSizeEnumTypeA
    {
        [EnumMember(Value = "TINY")]
        TINY = 1,
        [EnumMember(Value = "SMALL")]
        SMALL = 2,
        [EnumMember(Value = "MEDIUM")]
        MEDIUM = 3,
        [EnumMember(Value = "LARGE")]
        LARGE = 4,
        [EnumMember(Value = "XLARGE")]
        XLARGE = 5,
    }
}
