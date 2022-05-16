using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// 
    /// </summary>
    public enum VcenterTopologyNodesApplianceType
    {
        [EnumMember(Value = "VCSA_EMBEDDED")]
        VCSAEMBEDDED = 1,
        [EnumMember(Value = "VCSA_EXTERNAL")]
        VCSAEXTERNAL = 2,
        [EnumMember(Value = "PSC_EXTERNAL")]
        PSCEXTERNAL = 3,
    }
}
