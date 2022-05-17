using System.Runtime.Serialization;

namespace vspheresdk.Stats.Models.Enums
{
    /// <summary>
    /// Unit used by a metric. Warning: This enumeration is available as Technology Preview. These are early access APIs provided to test, automate and provide feedback on the feature. Since this can change based on feedback, VMware does not guarantee backwards compatibility and recommends against using them in production environments. Some Technology Preview APIs might only be applicable to specific environments.
    /// </summary>
    public enum VstatsCounterMetadataMetricUnitsEnumType
    {
        [EnumMember(Value = "PERCENT")]
        PERCENT = 1,
        [EnumMember(Value = "NUMBER")]
        NUMBER = 2,
        [EnumMember(Value = "SECOND")]
        SECOND = 3,
        [EnumMember(Value = "HERTZ")]
        HERTZ = 4,
        [EnumMember(Value = "METER")]
        METER = 5,
        [EnumMember(Value = "METERSPERSECOND")]
        METERSPERSECOND = 6,
        [EnumMember(Value = "METERSPERSECONDSQUARED")]
        METERSPERSECONDSQUARED = 7,
        [EnumMember(Value = "BYTE")]
        BYTE = 8,
        [EnumMember(Value = "BIT")]
        BIT = 9,
        [EnumMember(Value = "BYTESPERSECOND")]
        BYTESPERSECOND = 10,
        [EnumMember(Value = "BITSPERSECOND")]
        BITSPERSECOND = 11,
        [EnumMember(Value = "KILOGRAM")]
        KILOGRAM = 12,
        [EnumMember(Value = "GRAM")]
        GRAM = 13,
        [EnumMember(Value = "CELSIUS")]
        CELSIUS = 14,
        [EnumMember(Value = "KELVIN")]
        KELVIN = 15,
        [EnumMember(Value = "JOULE")]
        JOULE = 16,
        [EnumMember(Value = "WATT")]
        WATT = 17,
        [EnumMember(Value = "VOLT")]
        VOLT = 18,
        [EnumMember(Value = "AMPERE")]
        AMPERE = 19,
        [EnumMember(Value = "VOLTAMPERE")]
        VOLTAMPERE = 20,
        [EnumMember(Value = "CANDELA")]
        CANDELA = 21,
        [EnumMember(Value = "MOLE")]
        MOLE = 22,
    }
}
