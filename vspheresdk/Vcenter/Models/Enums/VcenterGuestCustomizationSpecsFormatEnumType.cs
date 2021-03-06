using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The CustomizationSpecs.Format enumerated type specifies the formats the customization specification can be exported to.
    /// </summary>
    public enum VcenterGuestCustomizationSpecsFormatEnumType
    {
        [EnumMember(Value = "JSON")]
        JSON = 1,
        [EnumMember(Value = "XML")]
        XML = 2,
    }
}
