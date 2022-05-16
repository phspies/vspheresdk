using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Providers.ConfigType structure contains the possible types of vCenter Server identity providers.
    /// </summary>
    public enum VcenterIdentityProvidersConfigTypeA
    {
        [EnumMember(Value = "OAUTH2")]
        Oauth2 = 1,
        [EnumMember(Value = "OIDC")]
        Oidc = 2,
    }
}
