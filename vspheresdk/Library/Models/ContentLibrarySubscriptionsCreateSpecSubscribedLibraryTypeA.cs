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
    public class ContentLibrarySubscriptionsCreateSpecSubscribedLibraryTypeA 
    {
        /// <summary>
        /// Specifies whether the target subscribed library should be newly created or an existing subscribed library should be
        /// used.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "target", Required = Required.AllowNull)]
        public ContentLibrarySubscriptionsCreateSpecSubscribedLibraryTargetEnumTypeA Target { get; set; }
        /// <summary>
        /// Specification for creating a new subscribed library associated with the subscription.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "new_subscribed_library")]
        public ContentLibrarySubscriptionsCreateSpecNewSubscribedLibraryTypeA NewSubscribedLibrary { get; set; }
        /// <summary>
        /// Identifier of the existing subscribed library to associate with the subscription. Only the subscribed libraries for
        /// which {@link SubscriptionInfo#subscriptionUrl} property is set to the {@link PublishInfo#publishUrl} of the published
        /// library can be associated with the subscription.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "subscribed_library")]
        public string? SubscribedLibrary { get; set; }
        /// <summary>
        /// Location of the subscribed library relative to the published library.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "location", Required = Required.AllowNull)]
        public ContentLibrarySubscriptionsLocationEnumTypeA Location { get; set; }
        /// <summary>
        /// Specification for the subscribed library's vCenter Server instance.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vcenter")]
        public ContentLibrarySubscriptionsCreateSpecVcenterTypeA Vcenter { get; set; }
        /// <summary>
        /// Placement specification for the virtual machine template library items on the subscribed library.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "placement")]
        public ContentLibrarySubscriptionsCreateSpecPlacementTypeA Placement { get; set; }
    }
}
