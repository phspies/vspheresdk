using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Tools.VersionStatus enumerated type defines the version status types of VMware Tools installed in the guest operating system.
    /// </summary>
    public enum VcenterVmToolsVersionStatusType
    {
        [EnumMember(Value = "NOT_INSTALLED")]
        NOTINSTALLED = 1,
        [EnumMember(Value = "CURRENT")]
        CURRENT = 2,
        [EnumMember(Value = "UNMANAGED")]
        UNMANAGED = 3,
        [EnumMember(Value = "TOO_OLD_UNSUPPORTED")]
        TOOOLDUNSUPPORTED = 4,
        [EnumMember(Value = "SUPPORTED_OLD")]
        SUPPORTEDOLD = 5,
        [EnumMember(Value = "SUPPORTED_NEW")]
        SUPPORTEDNEW = 6,
        [EnumMember(Value = "TOO_NEW")]
        TOONEW = 7,
        [EnumMember(Value = "BLACKLISTED")]
        BLACKLISTED = 8,
    }
}
