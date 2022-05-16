using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The IpFamily enumerated type defines the Ip address family.
    /// </summary>
    public enum VcenterVchaIpFamilyType
    {
        [EnumMember(Value = "IPV4")]
        IPV4 = 1,
        [EnumMember(Value = "IPV6")]
        IPV6 = 2,
    }
}
