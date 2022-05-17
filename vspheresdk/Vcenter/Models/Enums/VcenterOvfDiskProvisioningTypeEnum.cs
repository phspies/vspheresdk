using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The {@name DiskProvisioningType} {@term enumerated type} defines the virtual disk provisioning types that can be set for a disk on the target platform.
    /// </summary>
    public enum VcenterOvfDiskProvisioningTypeEnum
    {
        [EnumMember(Value = "THIN")]
        Thin = 1,
        [EnumMember(Value = "THICK")]
        Thick = 2,
        [EnumMember(Value = "EAGERZEROEDTHICK")]
        EagerZeroedThick = 3,
    }
}
