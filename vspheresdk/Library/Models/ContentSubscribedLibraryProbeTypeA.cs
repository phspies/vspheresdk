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
    public class ContentSubscribedLibraryProbeTypeA 
    {
        /// <summary>
        /// The subscription info to be probed.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "subscription_info", Required = Required.AllowNull)]
        public ContentLibrarySubscriptionInfoTypeA SubscriptionInfo { get; set; }
    }
}
