using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// 
    /// </summary>
    public enum VcenterDatastoreType
    {
        [EnumMember(Value = "VMFS")]
        VMFS = 1,
        [EnumMember(Value = "NFS")]
        NFS = 2,
        [EnumMember(Value = "NFS41")]
        NFS41 = 3,
        [EnumMember(Value = "CIFS")]
        CIFS = 4,
        [EnumMember(Value = "VSAN")]
        VSAN = 5,
        [EnumMember(Value = "VFFS")]
        VFFS = 6,
        [EnumMember(Value = "VVOL")]
        VVOL = 7,
    }
}
