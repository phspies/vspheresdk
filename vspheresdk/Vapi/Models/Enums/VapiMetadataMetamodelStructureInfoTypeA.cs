using System.Runtime.Serialization;

namespace vspheresdk.Vapi.Models.Enums
{
    /// <summary>
    /// The {@name Type} {@term enumerated type} defines the kind of this structure element. In the interface definition language, structure element and error element have similar characteristics. The difference is that only error elements can be used to describe the {@term errors} of an operation element.
    /// </summary>
    public enum VapiMetadataMetamodelStructureInfoTypeA
    {
        [EnumMember(Value = "STRUCTURE")]
        STRUCTURE = 1,
        [EnumMember(Value = "ERROR")]
        ERROR = 2,
    }
}
