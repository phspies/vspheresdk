using System.Runtime.Serialization;

namespace vspheresdk.Esx.Models.Enums
{
    /// <summary>
    /// The {@name SourceType} {@term enumerated type} defines possible values of sources to import software specification.
    /// </summary>
    public enum EsxSettingsClustersSoftwareDraftsSourceType
    {
        [EnumMember(Value = "PULL")]
        PULL = 1,
        [EnumMember(Value = "PUSH")]
        PUSH = 2,
        [EnumMember(Value = "JSON_STRING")]
        JSONSTRING = 3,
        [EnumMember(Value = "LATEST_RECOMMENDATION")]
        LATESTRECOMMENDATION = 4,
        [EnumMember(Value = "CURRENT_SERIES_RECOMMENDATION")]
        CURRENTSERIESRECOMMENDATION = 5,
        [EnumMember(Value = "SPECIFIED_BASE_IMAGE_RECOMMENDATION")]
        SPECIFIEDBASEIMAGERECOMMENDATION = 6,
    }
}
