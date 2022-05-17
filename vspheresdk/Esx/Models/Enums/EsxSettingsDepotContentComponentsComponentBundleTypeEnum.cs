using System.Runtime.Serialization;

namespace vspheresdk.Esx.Models.Enums
{
    /// <summary>
    /// 
    /// </summary>
    public enum EsxSettingsDepotContentComponentsComponentBundleTypeEnum
    {
        [EnumMember(Value = "INDEPENDENT")]
        INDEPENDENT = 1,
        [EnumMember(Value = "BASE_IMAGE")]
        BASEIMAGE = 2,
        [EnumMember(Value = "ADD_ON")]
        ADDON = 3,
    }
}
