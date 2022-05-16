using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Library.Models.Enums;

namespace vspheresdk.Library.Models
{
    public class ContentLocalLibraryPublishTypeA 
    {
        /// <summary>
        /// The list of subscriptions to publish this library to.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "subscriptions")]
        public Dictionary<string,ContentLocalLibraryDestinationSpecTypeA> Subscriptions { get; set; }
    }
}
