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
    public class VcenterTaggingAssociationsListResultType 
    {
        /// <summary>
        /// List of tag associations.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "associations", Required = Required.AllowNull)]
        public Dictionary<string,VcenterTaggingAssociationsSummaryType> Associations { get; set; }
        /// <summary>
        /// Marker is an opaque data structure that allows the caller to request the next page of tag associations.
        /// If unset or empty, there are no more tag associations to request.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vcenter.tagging.associations.Marker. When operations return a value of this structure as a result, the field will be an
        /// identifier for the resource type: vcenter.tagging.associations.Marker.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "marker")]
        public string? Marker { get; set; }
        /// <summary>
        /// The last status for the iterator that indicates whether any more results can be expected if the caller continues to make
        /// requests for more data using the iterator.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public VcenterTaggingAssociationsLastIterationStatusEnumType Status { get; set; }
    }
}
