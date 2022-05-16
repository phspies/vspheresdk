using System.Runtime.Serialization;

namespace vspheresdk.Library.Models.Enums
{
    /// <summary>
    /// The {@name ChecksumAlgorithm} {@term enumerated type} defines the valid checksum algorithms.
    /// </summary>
    public enum ContentLibraryItemFileChecksumAlgorithmTypeA
    {
        [EnumMember(Value = "SHA1")]
        SHA1 = 1,
        [EnumMember(Value = "MD5")]
        MD5 = 2,
        [EnumMember(Value = "SHA256")]
        SHA256 = 3,
        [EnumMember(Value = "SHA512")]
        SHA512 = 4,
    }
}
