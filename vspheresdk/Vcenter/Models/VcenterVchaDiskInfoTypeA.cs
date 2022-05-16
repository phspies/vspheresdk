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
    public class VcenterVchaDiskInfoTypeA 
    {
        /// <summary>
        /// The identifier of the datastore to put all the virtual disks on.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// Datastore:VCenter. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: Datastore:VCenter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "datastore", Required = Required.AllowNull)]
        public string Datastore { get; set; }
        /// <summary>
        /// The name of the datastore.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "datastore_name", Required = Required.AllowNull)]
        public string DatastoreName { get; set; }
    }
}
