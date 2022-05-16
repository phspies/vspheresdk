using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Tickets.Type enumerated type defines the types of console tickets.
    /// </summary>
    public enum VcenterVmConsoleTicketsType
    {
        [EnumMember(Value = "VMRC")]
        VMRC = 1,
        [EnumMember(Value = "WEBMKS")]
        WEBMKS = 2,
    }
}
