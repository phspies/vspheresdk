using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The ApplianceType enumerated type defines the vCenter appliance types.
    /// </summary>
    public enum VcenterDeploymentApplianceType
    {
        [EnumMember(Value = "VCSA_EMBEDDED")]
        VCSAEMBEDDED = 1,
        [EnumMember(Value = "VCSA_EXTERNAL")]
        VCSAEXTERNAL = 2,
        [EnumMember(Value = "PSC_EXTERNAL")]
        PSCEXTERNAL = 3,
    }
}
