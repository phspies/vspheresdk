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
    public class VcenterStoragePoliciesCompatibleDatastoreInfoTypeA 
    {
        /// <summary>
        /// Identifier of the datastore.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// Datastore. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: Datastore.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "datastore", Required = Required.AllowNull)]
        public string Datastore { get; set; }
    }
}
