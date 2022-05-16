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
    public class VcenterDatastoreInfoType 
    {
        /// <summary>
        /// Name of the datastore.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Type (Type) of the datastore.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public VcenterDatastoreType Type { get; set; }
        /// <summary>
        /// Whether or not this datastore is accessible.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "accessible", Required = Required.AllowNull)]
        public bool Accessible { get; set; }
        /// <summary>
        /// Available space of this datastore, in bytes.
        /// The server periodically updates this value.
        /// 
        /// This field will be unset if the available space of this datastore is not known.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "free_space")]
        public long? FreeSpace { get; set; }
        /// <summary>
        /// Whether or not more than one host in the datacenter has been configured with access to the datastore.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "multiple_host_access", Required = Required.AllowNull)]
        public bool MultipleHostAccess { get; set; }
        /// <summary>
        /// Whether or not the datastore supports thin provisioning on a per file basis. When thin provisioning is used, backing
        /// storage is lazily allocated.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "thin_provisioning_supported", Required = Required.AllowNull)]
        public bool ThinProvisioningSupported { get; set; }
    }
}
