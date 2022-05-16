using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Access.SubjectType enumerated type lists the types of subjects who can be associated with a Access.Role on the namespace.
    /// </summary>
    public enum VcenterNamespacesAccessSubjectTypeA
    {
        [EnumMember(Value = "USER")]
        USER = 1,
        [EnumMember(Value = "GROUP")]
        GROUP = 2,
    }
}
