using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The {@name Scope} {@term enumerated type} in a project defines access levels of the project.
    /// </summary>
    public enum VcenterContentRegistriesHarborProjectsScopeEnumTypeA
    {
        [EnumMember(Value = "PUBLIC")]
        PUBLIC = 1,
        [EnumMember(Value = "PRIVATE")]
        PRIVATE = 2,
    }
}
