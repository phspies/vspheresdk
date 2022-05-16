using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The {@name Type} {@term enumerated type} defines the supported types of storage targets for sections of type vmw:StorageGroupSection in the OVF descriptor.
    /// </summary>
    public enum VcenterOvfLibraryItemStorageGroupMappingType
    {
        [EnumMember(Value = "DATASTORE")]
        DATASTORE = 1,
        [EnumMember(Value = "STORAGE_PROFILE")]
        STORAGEPROFILE = 2,
    }
}
