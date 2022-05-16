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
    public class VcenterTaggingAssociationsIterationSpecType 
    {
        /// <summary>
        /// Marker is an opaque token that allows the caller to request the next page of tag associations.
        /// If unset or empty, first page of tag associations will be returned.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vcenter.tagging.associations.Marker. When operations return a value of this structure as a result, the field will be an
        /// identifier for the resource type: vcenter.tagging.associations.Marker.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "marker")]
        public string? Marker { get; set; }
    }
}
