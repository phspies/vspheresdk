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
    public class ContentLibrarySubscriptionsUpdateSpecType 
    {
        /// <summary>
        /// Specification for the subscribed library's vCenter Server instance.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "subscribed_library_vcenter")]
        public ContentLibrarySubscriptionsUpdateSpecVcenterType SubscribedLibraryVcenter { get; set; }
        /// <summary>
        /// Placement specification for the virtual machine template items of the subscribed library. Updating this information will
        /// only affect new or updated items, existing items will not be moved. The entire placement configuration of the subscribed
        /// library will replaced by the new specification.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "subscribed_library_placement")]
        public ContentLibrarySubscriptionsUpdateSpecPlacementType SubscribedLibraryPlacement { get; set; }
    }
}
