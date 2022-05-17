using System.Runtime.Serialization;

namespace vspheresdk.Library.Models.Enums
{
    /// <summary>
    /// The {@name Target} {@term enumerated type} defines the options related to the target subscribed library which will be associated with the subscription.
    /// </summary>
    public enum ContentLibrarySubscriptionsCreateSpecSubscribedLibraryTargetEnumTypeA
    {
        [EnumMember(Value = "CREATE_NEW")]
        CREATENEW = 1,
        [EnumMember(Value = "USE_EXISTING")]
        USEEXISTING = 2,
    }
}
