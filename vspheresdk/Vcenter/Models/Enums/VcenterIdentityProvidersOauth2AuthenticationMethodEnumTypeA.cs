using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Providers.Oauth2AuthenticationMethod structure contains the possible types of OAuth2 authentication methods.
    /// </summary>
    public enum VcenterIdentityProvidersOauth2AuthenticationMethodEnumTypeA
    {
        [EnumMember(Value = "CLIENT_SECRET_BASIC")]
        CLIENTSECRETBASIC = 1,
        [EnumMember(Value = "CLIENT_SECRET_POST")]
        CLIENTSECRETPOST = 2,
        [EnumMember(Value = "CLIENT_SECRET_JWT")]
        CLIENTSECRETJWT = 3,
        [EnumMember(Value = "PRIVATE_KEY_JWT")]
        PRIVATEKEYJWT = 4,
    }
}
