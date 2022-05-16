using System.Runtime.Serialization;

namespace vspheresdk.Library.Models.Enums
{
    /// <summary>
    /// The {@name CertVerificationStatus} {@term enumerated type} defines the certificate verification status of a library item. Currently applicable only to ovf item type
    /// </summary>
    public enum ContentLibraryItemCertVerificationStatusType
    {
        [EnumMember(Value = "NOT_AVAILABLE")]
        NOTAVAILABLE = 1,
        [EnumMember(Value = "VERIFIED")]
        VERIFIED = 2,
        [EnumMember(Value = "INTERNAL")]
        INTERNAL = 3,
        [EnumMember(Value = "VERIFICATION_FAILURE")]
        VERIFICATIONFAILURE = 4,
        [EnumMember(Value = "VERIFICATION_IN_PROGRESS")]
        VERIFICATIONINPROGRESS = 5,
        [EnumMember(Value = "UNTRUSTED")]
        UNTRUSTED = 6,
    }
}
