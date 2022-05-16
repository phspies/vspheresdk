using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The CloudConfiguration.Type enumerated type specifies different types of the cloud configuration.
    /// </summary>
    public enum VcenterGuestCloudConfigurationTypeA
    {
        [EnumMember(Value = "CLOUDINIT")]
        CLOUDINIT = 1,
    }
}
