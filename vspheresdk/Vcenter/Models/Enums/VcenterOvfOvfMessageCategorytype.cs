using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The {@name Category} {@term enumerated type} defines the categories of messages (see {@link OvfMessage}).
    /// </summary>
    public enum VcenterOvfOvfMessageCategoryType
    {
        [EnumMember(Value = "VALIDATION")]
        VALIDATION = 1,
        [EnumMember(Value = "INPUT")]
        INPUT = 2,
        [EnumMember(Value = "SERVER")]
        SERVER = 3,
    }
}
