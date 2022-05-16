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
    public class VcenterDatastoreFilterSpecTypeA 
    {
        /// <summary>
        /// Identifiers of datastores that can match the filter.
        /// If unset or empty, datastores with any identifier match the filter.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// Datastore. When operations return a value of this structure as a result, the field will contain identifiers for the
        /// resource type: Datastore.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "datastores")]
        public IList<string> Datastores { get; set; }
        /// <summary>
        /// Names that datastores must have to match the filter (see Datastore.Info.name).
        /// If unset or empty, datastores with any name match the filter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "names")]
        public IList<string> Names { get; set; }
        /// <summary>
        /// Types that datastores must have to match the filter (see Datastore.Summary.type).
        /// If unset or empty, datastores with any type match the filter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "types")]
        public Dictionary<string,VcenterDatastoreTypeA> Types { get; set; }
        /// <summary>
        /// Folders that must contain the datastore for the datastore to match the filter.
        /// If unset or empty, datastores in any folder match the filter.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// Folder. When operations return a value of this structure as a result, the field will contain identifiers for the
        /// resource type: Folder.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "folders")]
        public IList<string> Folders { get; set; }
        /// <summary>
        /// Datacenters that must contain the datastore for the datastore to match the filter.
        /// If unset or empty, datastores in any datacenter match the filter.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// Datacenter. When operations return a value of this structure as a result, the field will contain identifiers for the
        /// resource type: Datacenter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "datacenters")]
        public IList<string> Datacenters { get; set; }
    }
}
