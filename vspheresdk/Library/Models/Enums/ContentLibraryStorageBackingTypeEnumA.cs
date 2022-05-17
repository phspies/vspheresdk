using System.Runtime.Serialization;

namespace vspheresdk.Library.Models.Enums
{
    /// <summary>
    /// The {@name Type} {@term enumerated type} specifies the type of the {@link StorageBacking}.
    /// </summary>
    public enum ContentLibraryStorageBackingTypeEnumA
    {
        [EnumMember(Value = "DATASTORE")]
        DATASTORE = 1,
        [EnumMember(Value = "OTHER")]
        OTHER = 2,
    }
}
