using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Hardware.Version enumerated type defines the valid virtual hardware versions for a virtual machine. See https://kb.vmware.com/s/article/1003746 (Virtual machine hardware versions (1003746)).
    /// </summary>
    public enum VcenterVmHardwareVersionEnumTypeA
    {
        [EnumMember(Value = "VMX_03")]
        VMX03 = 1,
        [EnumMember(Value = "VMX_04")]
        VMX04 = 2,
        [EnumMember(Value = "VMX_06")]
        VMX06 = 3,
        [EnumMember(Value = "VMX_07")]
        VMX07 = 4,
        [EnumMember(Value = "VMX_08")]
        VMX08 = 5,
        [EnumMember(Value = "VMX_09")]
        VMX09 = 6,
        [EnumMember(Value = "VMX_10")]
        VMX10 = 7,
        [EnumMember(Value = "VMX_11")]
        VMX11 = 8,
        [EnumMember(Value = "VMX_12")]
        VMX12 = 9,
        [EnumMember(Value = "VMX_13")]
        VMX13 = 10,
        [EnumMember(Value = "VMX_14")]
        VMX14 = 11,
        [EnumMember(Value = "VMX_15")]
        VMX15 = 12,
        [EnumMember(Value = "VMX_16")]
        VMX16 = 13,
        [EnumMember(Value = "VMX_17")]
        VMX17 = 14,
        [EnumMember(Value = "VMX_18")]
        VMX18 = 15,
        [EnumMember(Value = "VMX_19")]
        VMX19 = 16,
    }
}
