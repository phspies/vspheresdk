using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Scsi.Type enumerated type defines the valid emulation types for a virtual SCSI adapter.
    /// </summary>
    public enum VcenterVmHardwareAdapterScsiTypeEnumA
    {
        [EnumMember(Value = "BUSLOGIC")]
        BUSLOGIC = 1,
        [EnumMember(Value = "LSILOGIC")]
        LSILOGIC = 2,
        [EnumMember(Value = "LSILOGICSAS")]
        LSILOGICSAS = 3,
        [EnumMember(Value = "PVSCSI")]
        PVSCSI = 4,
    }
}
