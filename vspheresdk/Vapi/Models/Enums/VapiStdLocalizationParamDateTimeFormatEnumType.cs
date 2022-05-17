using System.Runtime.Serialization;

namespace vspheresdk.Vapi.Models.Enums
{
    /// <summary>
    /// The {@name DateTimeFormat} {@term enumerated type} lists possible date and time formatting options. It combines the Unicode CLDR format types - full, long, medium and short with 3 different presentations - date only, time only and combined date and time presentation.
    /// </summary>
    public enum VapiStdLocalizationParamDateTimeFormatEnumType
    {
        [EnumMember(Value = "SHORT_DATE")]
        SHORTDATE = 1,
        [EnumMember(Value = "MED_DATE")]
        MEDDATE = 2,
        [EnumMember(Value = "LONG_DATE")]
        LONGDATE = 3,
        [EnumMember(Value = "FULL_DATE")]
        FULLDATE = 4,
        [EnumMember(Value = "SHORT_TIME")]
        SHORTTIME = 5,
        [EnumMember(Value = "MED_TIME")]
        MEDTIME = 6,
        [EnumMember(Value = "LONG_TIME")]
        LONGTIME = 7,
        [EnumMember(Value = "FULL_TIME")]
        FULLTIME = 8,
        [EnumMember(Value = "SHORT_DATE_TIME")]
        SHORTDATETIME = 9,
        [EnumMember(Value = "MED_DATE_TIME")]
        MEDDATETIME = 10,
        [EnumMember(Value = "LONG_DATE_TIME")]
        LONGDATETIME = 11,
        [EnumMember(Value = "FULL_DATE_TIME")]
        FULLDATETIME = 12,
    }
}
