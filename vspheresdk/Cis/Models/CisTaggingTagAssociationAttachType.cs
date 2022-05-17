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
    public class CisTaggingTagAssociationAttachType 
    {
        /// <summary>
        /// The identifier of the input object.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "object_id", Required = Required.AllowNull)]
        public VapiStdDynamicIdtype ObjectId { get; set; }
    }
}
