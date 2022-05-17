using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Providers.IdmProtocol structure contains the possible types of communication protocols to the identity management endpoints.
    /// </summary>
    public enum VcenterIdentityProvidersIdmProtocolEnumType
    {
        [EnumMember(Value = "REST")]
        REST = 1,
        [EnumMember(Value = "SCIM")]
        SCIM = 2,
        [EnumMember(Value = "SCIM2_0")]
        SCIM20 = 3,
        [EnumMember(Value = "LDAP")]
        LDAP = 4,
    }
}
