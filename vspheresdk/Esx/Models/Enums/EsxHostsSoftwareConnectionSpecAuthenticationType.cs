using System.Runtime.Serialization;

namespace vspheresdk.Esx.Models.Enums
{
    /// <summary>
    /// The {@name AuthenticationType} {@term enumerated type} defines the possible types of authentication supported when connecting to the host.
    /// </summary>
    public enum EsxHostsSoftwareConnectionSpecAuthenticationType
    {
        [EnumMember(Value = "USERNAME_PASSWORD")]
        USERNAMEPASSWORD = 1,
        [EnumMember(Value = "EXISTING")]
        EXISTING = 2,
    }
}
