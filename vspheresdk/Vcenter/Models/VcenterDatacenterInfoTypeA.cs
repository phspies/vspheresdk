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
    public class VcenterDatacenterInfoTypeA 
    {
        /// <summary>
        /// The name of the datacenter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// The root datastore folder associated with the datacenter.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// Folder. When operations return a value of this structure as a result, the field will be an identifier for the resource
        /// type: Folder.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "datastore_folder", Required = Required.AllowNull)]
        public string DatastoreFolder { get; set; }
        /// <summary>
        /// The root host and cluster folder associated with the datacenter.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// Folder. When operations return a value of this structure as a result, the field will be an identifier for the resource
        /// type: Folder.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "host_folder", Required = Required.AllowNull)]
        public string HostFolder { get; set; }
        /// <summary>
        /// The root network folder associated with the datacenter.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// Folder. When operations return a value of this structure as a result, the field will be an identifier for the resource
        /// type: Folder.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "network_folder", Required = Required.AllowNull)]
        public string NetworkFolder { get; set; }
        /// <summary>
        /// The root virtual machine folder associated with the datacenter.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// Folder. When operations return a value of this structure as a result, the field will be an identifier for the resource
        /// type: Folder.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vm_folder", Required = Required.AllowNull)]
        public string VmFolder { get; set; }
    }
}
