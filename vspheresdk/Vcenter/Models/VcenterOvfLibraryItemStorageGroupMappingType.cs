using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Vcenter.Models.Enums;

namespace vspheresdk.Vcenter.Models
{
    public class VcenterOvfLibraryItemStorageGroupMappingType 
    {
        /// <summary>
        /// Type of storage deployment target to use for the vmw:StorageGroupSection section. The specified value must be {@link
        /// Type#DATASTORE} or {@link Type#STORAGE_PROFILE}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public VcenterOvfLibraryItemStorageGroupMappingTypeEnum Type { get; set; }
        /// <summary>
        /// Target datastore to be used for the storage group.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "datastore_id")]
        public string? DatastoreId { get; set; }
        /// <summary>
        /// Target storage profile to be used for the storage group.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "storage_profile_id")]
        public string? StorageProfileId { get; set; }
        /// <summary>
        /// Target provisioning type to use for the storage group.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "provisioning")]
        public VcenterOvfDiskProvisioningTypeEnum Provisioning { get; set; }
    }
}
