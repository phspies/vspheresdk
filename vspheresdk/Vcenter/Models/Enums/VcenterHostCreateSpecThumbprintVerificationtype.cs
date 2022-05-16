using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Host.CreateSpec.ThumbprintVerification enumerated type defines the thumbprint verification schemes for a host&apos;s SSL certificate.
    /// </summary>
    public enum VcenterHostCreateSpecThumbprintVerificationType
    {
        [EnumMember(Value = "NONE")]
        NONE = 1,
        [EnumMember(Value = "THUMBPRINT")]
        THUMBPRINT = 2,
    }
}
