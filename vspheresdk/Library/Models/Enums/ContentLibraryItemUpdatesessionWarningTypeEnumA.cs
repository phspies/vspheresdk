using System.Runtime.Serialization;

namespace vspheresdk.Library.Models.Enums
{
    /// <summary>
    /// The {@name WarningType} {@term enumerated type} defines the warnings which can be raised during the update session.
    /// </summary>
    public enum ContentLibraryItemUpdatesessionWarningTypeEnumA
    {
        [EnumMember(Value = "SELF_SIGNED_CERTIFICATE")]
        SELFSIGNEDCERTIFICATE = 1,
        [EnumMember(Value = "EXPIRED_CERTIFICATE")]
        EXPIREDCERTIFICATE = 2,
        [EnumMember(Value = "NOT_YET_VALID_CERTIFICATE")]
        NOTYETVALIDCERTIFICATE = 3,
        [EnumMember(Value = "UNTRUSTED_CERTIFICATE")]
        UNTRUSTEDCERTIFICATE = 4,
    }
}
