using System.Runtime.Serialization;

namespace vspheresdk.Esx.Models.Enums
{
    /// <summary>
    /// The {@name CategoryType} {@term enumerated type} defines possible values of categories for a component.
    /// </summary>
    public enum EsxSettingsDepotContentComponentsVersionsCategoryTypeEnum
    {
        [EnumMember(Value = "SECURITY")]
        SECURITY = 1,
        [EnumMember(Value = "ENHANCEMENT")]
        ENHANCEMENT = 2,
        [EnumMember(Value = "BUGFIX")]
        BUGFIX = 3,
        [EnumMember(Value = "RECALL")]
        RECALL = 4,
        [EnumMember(Value = "RECALL_FIX")]
        RECALLFIX = 5,
        [EnumMember(Value = "INFO")]
        INFO = 6,
        [EnumMember(Value = "MISC")]
        MISC = 7,
        [EnumMember(Value = "GENERAL")]
        GENERAL = 8,
    }
}
