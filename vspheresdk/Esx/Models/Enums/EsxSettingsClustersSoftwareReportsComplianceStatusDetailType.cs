using System.Runtime.Serialization;

namespace vspheresdk.Esx.Models.Enums
{
    /// <summary>
    /// The {@name ComplianceStatusDetail} {@term enumerated type} contains the essential status values for compliance with respect to target VMware Compatibility Guide (VCG)
    /// </summary>
    public enum EsxSettingsClustersSoftwareReportsComplianceStatusDetailType
    {
        [EnumMember(Value = "CERTIFIED")]
        CERTIFIED = 1,
        [EnumMember(Value = "NOT_CERTIFIED")]
        NOTCERTIFIED = 2,
        [EnumMember(Value = "HCL_DATA_UNAVAILABLE")]
        HCLDATAUNAVAILABLE = 3,
        [EnumMember(Value = "HOSTS_UNAVAILABLE")]
        HOSTSUNAVAILABLE = 4,
        [EnumMember(Value = "FIRMWARE_VERSION_UNKNOWN")]
        FIRMWAREVERSIONUNKNOWN = 5,
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN = 6,
        [EnumMember(Value = "VENDOR_UPDATE")]
        VENDORUPDATE = 7,
        [EnumMember(Value = "USER_VERIFIED")]
        USERVERIFIED = 8,
        [EnumMember(Value = "USER_FLAGGED")]
        USERFLAGGED = 9,
        [EnumMember(Value = "MUTED")]
        MUTED = 10,
    }
}
