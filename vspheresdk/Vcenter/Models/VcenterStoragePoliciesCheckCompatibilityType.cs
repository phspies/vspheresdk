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
    public class VcenterStoragePoliciesCheckCompatibilityType 
    {
        /// <summary>
        /// Datastores used to check compatibility against a storage policy. The number of datastores is limited to 1024.
        /// The parameter must contain identifiers for the resource type: Datastore.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "datastores", Required = Required.AllowNull)]
        public IList<string> Datastores { get; set; }
    }
}
