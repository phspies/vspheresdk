using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Sata.Type enumerated type defines the valid emulation types for a virtual SATA adapter.
    /// </summary>
    public enum VcenterVmHardwareAdapterSataTypeA
    {
        [EnumMember(Value = "AHCI")]
        AHCI = 1,
    }
}
