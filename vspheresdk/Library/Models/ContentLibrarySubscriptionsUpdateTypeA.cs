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
    public class ContentLibrarySubscriptionsUpdateTypeA 
    {
        /// <summary>
        /// subscription identifier.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "subscription", Required = Required.AllowNull)]
        public string Subscription { get; set; }
        /// <summary>
        /// Specification of the new property values to set on the subscription.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "spec", Required = Required.AllowNull)]
        public ContentLibrarySubscriptionsUpdateSpecTypeA Spec { get; set; }
    }
}
