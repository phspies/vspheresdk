using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Versions.ContentType enumerated type defines the type of content that describes the format of Supervisor Service version definition.
    /// </summary>
    public enum VcenterNamespaceManagementSupervisorServicesVersionsContentTypeEnum
    {
        [EnumMember(Value = "VSPHERE_APPS_YAML")]
        VSPHEREAPPSYAML = 1,
        [EnumMember(Value = "CUSTOM_YAML")]
        CUSTOMYAML = 2,
    }
}
