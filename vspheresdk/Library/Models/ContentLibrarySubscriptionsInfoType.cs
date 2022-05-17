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
    public class ContentLibrarySubscriptionsInfoType 
    {
        /// <summary>
        /// Identifier of the subscribed library associated with the subscription.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "subscribed_library", Required = Required.AllowNull)]
        public string SubscribedLibrary { get; set; }
        /// <summary>
        /// Name of the subscribed library associated with the subscription.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "subscribed_library_name", Required = Required.AllowNull)]
        public string SubscribedLibraryName { get; set; }
        /// <summary>
        /// Location of the subscribed library relative to the published library.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "subscribed_library_location", Required = Required.AllowNull)]
        public ContentLibrarySubscriptionsLocationEnumType SubscribedLibraryLocation { get; set; }
        /// <summary>
        /// Information about the vCenter Server instance where the subscribed library exists.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "subscribed_library_vcenter")]
        public ContentLibrarySubscriptionsVcenterInfoType SubscribedLibraryVcenter { get; set; }
        /// <summary>
        /// Placement information about the subscribed library's virtual machine template items.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "subscribed_library_placement", Required = Required.AllowNull)]
        public ContentLibrarySubscriptionsPlacementInfoType SubscribedLibraryPlacement { get; set; }
    }
}
