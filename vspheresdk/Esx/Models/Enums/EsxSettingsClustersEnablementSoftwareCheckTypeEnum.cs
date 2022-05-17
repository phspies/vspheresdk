using System.Runtime.Serialization;

namespace vspheresdk.Esx.Models.Enums
{
    /// <summary>
    /// The {@name CheckType} {@term enumerated type} contains various checks to identify the possibility to enable the feature that manages the cluster with a single software specification.
    /// </summary>
    public enum EsxSettingsClustersEnablementSoftwareCheckTypeEnum
    {
        [EnumMember(Value = "SOFTWARE")]
        SOFTWARE = 1,
        [EnumMember(Value = "VERSION")]
        VERSION = 2,
        [EnumMember(Value = "STATELESSNESS")]
        STATELESSNESS = 3,
        [EnumMember(Value = "VUM_REMEDIATION")]
        VUMREMEDIATION = 4,
        [EnumMember(Value = "SOFTWARE_SPECIFICATION_EXISTENCE")]
        SOFTWARESPECIFICATIONEXISTENCE = 5,
        [EnumMember(Value = "VSAN_WITNESS_ELIGIBILITY")]
        VSANWITNESSELIGIBILITY = 6,
    }
}
