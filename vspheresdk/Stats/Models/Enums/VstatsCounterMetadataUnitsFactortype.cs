using System.Runtime.Serialization;

namespace vspheresdk.Stats.Models.Enums
{
    /// <summary>
    /// Unit factor of measurement. Warning: This enumeration is available as Technology Preview. These are early access APIs provided to test, automate and provide feedback on the feature. Since this can change based on feedback, VMware does not guarantee backwards compatibility and recommends against using them in production environments. Some Technology Preview APIs might only be applicable to specific environments.
    /// </summary>
    public enum VstatsCounterMetadataUnitsFactorType
    {
        [EnumMember(Value = "YOTTA")]
        YOTTA = 1,
        [EnumMember(Value = "ZETTA")]
        ZETTA = 2,
        [EnumMember(Value = "EXA")]
        EXA = 3,
        [EnumMember(Value = "PETA")]
        PETA = 4,
        [EnumMember(Value = "TERA")]
        TERA = 5,
        [EnumMember(Value = "GIGA")]
        GIGA = 6,
        [EnumMember(Value = "MEGA")]
        MEGA = 7,
        [EnumMember(Value = "KILO")]
        KILO = 8,
        [EnumMember(Value = "HECTO")]
        HECTO = 9,
        [EnumMember(Value = "DECA")]
        DECA = 10,
        [EnumMember(Value = "ONE")]
        ONE = 11,
        [EnumMember(Value = "DECI")]
        DECI = 12,
        [EnumMember(Value = "CENTI")]
        CENTI = 13,
        [EnumMember(Value = "MILLI")]
        MILLI = 14,
        [EnumMember(Value = "MICRO")]
        MICRO = 15,
        [EnumMember(Value = "NANO")]
        NANO = 16,
        [EnumMember(Value = "PIKO")]
        PIKO = 17,
        [EnumMember(Value = "FEMTO")]
        FEMTO = 18,
        [EnumMember(Value = "ATTO")]
        ATTO = 19,
        [EnumMember(Value = "ZEPTO")]
        ZEPTO = 20,
        [EnumMember(Value = "YOCTO")]
        YOCTO = 21,
        [EnumMember(Value = "YOBI")]
        YOBI = 22,
        [EnumMember(Value = "ZEBI")]
        ZEBI = 23,
        [EnumMember(Value = "EXBI")]
        EXBI = 24,
        [EnumMember(Value = "PEBI")]
        PEBI = 25,
        [EnumMember(Value = "TEBI")]
        TEBI = 26,
        [EnumMember(Value = "GIBI")]
        GIBI = 27,
        [EnumMember(Value = "MEBI")]
        MEBI = 28,
        [EnumMember(Value = "KIBI")]
        KIBI = 29,
    }
}
