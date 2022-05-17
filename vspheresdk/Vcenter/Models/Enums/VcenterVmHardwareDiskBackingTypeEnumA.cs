using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Disk.BackingType enumerated type defines the valid backing types for a virtual disk.
    /// </summary>
    public enum VcenterVmHardwareDiskBackingTypeEnumA
    {
        [EnumMember(Value = "VMDK_FILE")]
        VMDKFILE = 1,
    }
}
