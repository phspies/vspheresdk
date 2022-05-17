using System.Runtime.Serialization;

namespace vspheresdk.Cis.Models.Enums
{
    /// <summary>
    /// The CategoryModel.Cardinality enumerated type defines the number of tags in a category that can be assigned to an object.
    /// </summary>
    public enum CisTaggingCategoryModelCardinalityEnumType
    {
        [EnumMember(Value = "SINGLE")]
        SINGLE = 1,
        [EnumMember(Value = "MULTIPLE")]
        MULTIPLE = 2,
    }
}
