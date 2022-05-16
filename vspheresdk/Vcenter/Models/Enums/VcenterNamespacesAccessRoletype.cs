using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Access.Role enumerated type lists the default roles which can be associated with a subject on a domain on the namespace.
    /// </summary>
    public enum VcenterNamespacesAccessRoleType
    {
        [EnumMember(Value = "OWNER")]
        OWNER = 1,
        [EnumMember(Value = "EDIT")]
        EDIT = 2,
        [EnumMember(Value = "VIEW")]
        VIEW = 3,
    }
}
