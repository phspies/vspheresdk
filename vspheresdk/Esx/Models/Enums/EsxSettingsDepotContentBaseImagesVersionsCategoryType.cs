using System.Runtime.Serialization;

namespace vspheresdk.Esx.Models.Enums
{
    /// <summary>
    /// The {@name CategoryType} {@term enumerated type} defines possible values of categories for a base-image.
    /// </summary>
    public enum EsxSettingsDepotContentBaseImagesVersionsCategoryType
    {
        [EnumMember(Value = "SECURITY")]
        SECURITY = 1,
        [EnumMember(Value = "ENHANCEMENT")]
        ENHANCEMENT = 2,
        [EnumMember(Value = "BUGFIX")]
        BUGFIX = 3,
    }
}
