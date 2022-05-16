using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// Types of guest credentials
    /// </summary>
    public enum VcenterVmGuestCredentialsTypeA
    {
        [EnumMember(Value = "USERNAME_PASSWORD")]
        USERNAMEPASSWORD = 1,
        [EnumMember(Value = "SAML_BEARER_TOKEN")]
        SAMLBEARERTOKEN = 2,
    }
}
