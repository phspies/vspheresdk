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
    public class VcenterVminstantClonePlacementSpecType 
    {
        /// <summary>
        /// Virtual machine folder into which the InstantCloned virtual machine should be placed.
        /// If field is unset, the system will use the virtual machine folder of the source virtual machine.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// Folder. When operations return a value of this structure as a result, the field will be an identifier for the resource
        /// type: Folder.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "folder")]
        public string? Folder { get; set; }
        /// <summary>
        /// Resource pool into which the InstantCloned virtual machine should be placed.
        /// If field is unset, the system will use the resource pool of the source virtual machine.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// ResourcePool. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: ResourcePool.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "resource_pool")]
        public string? ResourcePool { get; set; }
        /// <summary>
        /// Datastore on which the InstantCloned virtual machine's configuration state should be stored. This datastore will also be
        /// used for any virtual disks that are created as part of the virtual machine InstantClone operation.
        /// If field is unset, the system will use the datastore of the source virtual machine.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// Datastore. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: Datastore.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "datastore")]
        public string? Datastore { get; set; }
    }
}
