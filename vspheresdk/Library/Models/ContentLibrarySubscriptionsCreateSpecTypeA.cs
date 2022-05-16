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
    public class ContentLibrarySubscriptionsCreateSpecTypeA 
    {
        /// <summary>
        /// Specification for the subscribed library to be associated with the subscription.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "subscribed_library", Required = Required.AllowNull)]
        public ContentLibrarySubscriptionsCreateSpecSubscribedLibraryTypeA SubscribedLibrary { get; set; }
    }
}
