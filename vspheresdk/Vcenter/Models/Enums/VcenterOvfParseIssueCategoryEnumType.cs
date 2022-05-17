using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The {@name Category} {@term enumerated type} defines the categories of issues that can be found when parsing files inside an OVF package (see {@link ParseIssue}) including OVF descriptor (which is an XML document), manifest and certificate files, or exporting an OVF package.
    /// </summary>
    public enum VcenterOvfParseIssueCategoryEnumType
    {
        [EnumMember(Value = "VALUE_ILLEGAL")]
        VALUEILLEGAL = 1,
        [EnumMember(Value = "ATTRIBUTE_REQUIRED")]
        ATTRIBUTEREQUIRED = 2,
        [EnumMember(Value = "ATTRIBUTE_ILLEGAL")]
        ATTRIBUTEILLEGAL = 3,
        [EnumMember(Value = "ELEMENT_REQUIRED")]
        ELEMENTREQUIRED = 4,
        [EnumMember(Value = "ELEMENT_ILLEGAL")]
        ELEMENTILLEGAL = 5,
        [EnumMember(Value = "ELEMENT_UNKNOWN")]
        ELEMENTUNKNOWN = 6,
        [EnumMember(Value = "SECTION_UNKNOWN")]
        SECTIONUNKNOWN = 7,
        [EnumMember(Value = "SECTION_RESTRICTION")]
        SECTIONRESTRICTION = 8,
        [EnumMember(Value = "PARSE_ERROR")]
        PARSEERROR = 9,
        [EnumMember(Value = "GENERATE_ERROR")]
        GENERATEERROR = 10,
        [EnumMember(Value = "VALIDATION_ERROR")]
        VALIDATIONERROR = 11,
        [EnumMember(Value = "EXPORT_ERROR")]
        EXPORTERROR = 12,
        [EnumMember(Value = "INTERNAL_ERROR")]
        INTERNALERROR = 13,
    }
}
