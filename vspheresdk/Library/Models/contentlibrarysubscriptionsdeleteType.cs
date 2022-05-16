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
    public class ContentLibrarySubscriptionsDeleteType 
    {
        /// <summary>
        /// Subscription identifier.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "subscription", Required = Required.AllowNull)]
        public string Subscription { get; set; }
    }
}
