using System.Runtime.Serialization;

namespace vspheresdk.Library.Models.Enums
{
    /// <summary>
    /// The {@name LibraryType} {@term enumerated type} defines the type of a {@link LibraryModel}. &lt;p&gt; The type of a library can be used to determine which additional services can be performed with a library.
    /// </summary>
    public enum ContentLibraryModelLibraryType
    {
        [EnumMember(Value = "LOCAL")]
        LOCAL = 1,
        [EnumMember(Value = "SUBSCRIBED")]
        SUBSCRIBED = 2,
    }
}
