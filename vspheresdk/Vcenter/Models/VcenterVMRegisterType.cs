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
    public class VcenterVmregisterType 
    {
        /// <summary>
        /// Identifier of the datastore on which the virtual machine's configuration state is stored.
        /// If unset, VM.RegisterSpec.path must also be unset and VM.RegisterSpec.datastore-path must be set.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// Datastore. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: Datastore.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "datastore")]
        public string? Datastore { get; set; }
        /// <summary>
        /// Path to the virtual machine's configuration file on the datastore corresponding to {@link #datastore).
        /// If unset, VM.RegisterSpec.datastore must also be unset and VM.RegisterSpec.datastore-path must be set.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string? Path { get; set; }
        /// <summary>
        /// Datastore path for the virtual machine's configuration file in the format "[datastore name] path". For example
        /// "[storage1] Test-VM/Test-VM.vmx".
        /// If unset, both VM.RegisterSpec.datastore and VM.RegisterSpec.path must be set.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "datastore_path")]
        public string? DatastorePath { get; set; }
        /// <summary>
        /// Virtual machine name.
        /// If unset, the display name from the virtual machine's configuration file will be used.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Virtual machine placement information.
        /// This field is currently required. In the future, if this field is unset, the system will attempt to choose suitable
        /// resources on which to place the virtual machine.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "placement")]
        public VcenterVmregisterPlacementSpecType Placement { get; set; }
    }
}
