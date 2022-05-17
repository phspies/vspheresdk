using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Cis.Models.Enums;

namespace vspheresdk.Cis.Models
{
    public class CisTaggingTagAssociationDetachTagFromMultipleObjectsType 
    {
        /// <summary>
        /// The identifiers of the input objects.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "object_ids", Required = Required.AllowNull)]
        public Dictionary<string,VapiStdDynamicIdtype> ObjectIds { get; set; }
    }
}
