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
    public class ContentSubscribedLibraryProbeType 
    {
        /// <summary>
        /// The subscription info to be probed.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "subscription_info", Required = Required.AllowNull)]
        public ContentLibrarySubscriptionInfoType SubscriptionInfo { get; set; }
    }
}
