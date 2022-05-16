using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Folder.Type enumerated type defines the type of a vCenter Server folder. The type of a folder determines what what kinds of children can be contained in the folder.
    /// </summary>
    public enum VcenterFolderType
    {
        [EnumMember(Value = "DATACENTER")]
        DATACENTER = 1,
        [EnumMember(Value = "DATASTORE")]
        DATASTORE = 2,
        [EnumMember(Value = "HOST")]
        HOST = 3,
        [EnumMember(Value = "NETWORK")]
        NETWORK = 4,
        [EnumMember(Value = "VIRTUAL_MACHINE")]
        VIRTUALMACHINE = 5,
    }
}
