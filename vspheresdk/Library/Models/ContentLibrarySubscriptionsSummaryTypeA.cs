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
    public class ContentLibrarySubscriptionsSummaryTypeA 
    {
        /// <summary>
        /// Identifier of the subscription.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "subscription", Required = Required.AllowNull)]
        public string Subscription { get; set; }
        /// <summary>
        /// Identifier of the subscribed library.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "subscribed_library", Required = Required.AllowNull)]
        public string SubscribedLibrary { get; set; }
        /// <summary>
        /// Name of the subscribed library.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "subscribed_library_name", Required = Required.AllowNull)]
        public string SubscribedLibraryName { get; set; }
        /// <summary>
        /// Hostname of the vCenter instance where the subscribed library exists.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "subscribed_library_vcenter_hostname")]
        public string? SubscribedLibraryVcenterHostname { get; set; }
    }
}
