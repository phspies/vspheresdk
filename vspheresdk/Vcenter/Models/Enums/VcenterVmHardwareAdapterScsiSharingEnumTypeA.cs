using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Scsi.Sharing enumerated type defines the valid bus sharing modes for a virtual SCSI adapter.
    /// </summary>
    public enum VcenterVmHardwareAdapterScsiSharingEnumTypeA
    {
        [EnumMember(Value = "NONE")]
        NONE = 1,
        [EnumMember(Value = "VIRTUAL")]
        VIRTUAL = 2,
        [EnumMember(Value = "PHYSICAL")]
        PHYSICAL = 3,
    }
}
