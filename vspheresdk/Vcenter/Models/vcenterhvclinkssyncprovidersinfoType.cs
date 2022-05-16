using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Vcenter.Models.Enums;

namespace vspheresdk.Vcenter.Models
{
    public class VcenterHvcLinksSyncProvidersInfoType 
    {
        /// <summary>
        /// Last sync time for the provider. This indicates the last time that either a background sync or a force sync was started
        /// for the provider *Warning:* This attribute is available as Technology Preview. These are early access APIs provided to
        /// test, automate and provide feedback on the feature. Since this can change based on feedback, VMware does not guarantee
        /// backwards compatibility and recommends against using them in production environments. Some Technology Preview APIs might
        /// only be applicable to specific environments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "last_sync_time")]
        public DateTime? LastSyncTime { get; set; }
        /// <summary>
        /// Last Sync status for the provider. *Warning:* This attribute is available as Technology Preview. These are early access
        /// APIs provided to test, automate and provide feedback on the feature. Since this can change based on feedback, VMware
        /// does not guarantee backwards compatibility and recommends against using them in production environments. Some Technology
        /// Preview APIs might only be applicable to specific environments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public VcenterHvcLinksSyncProvidersStatusType Status { get; set; }
        /// <summary>
        /// Sync Polling interval between local and remote replicas for the provider *Warning:* This attribute is available as
        /// Technology Preview. These are early access APIs provided to test, automate and provide feedback on the feature. Since
        /// this can change based on feedback, VMware does not guarantee backwards compatibility and recommends against using them
        /// in production environments. Some Technology Preview APIs might only be applicable to specific environments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "polling_interval_in_seconds", Required = Required.AllowNull)]
        public long PollingIntervalInSeconds { get; set; }
        /// <summary>
        /// Returns information on the forced sync for the provider. *Warning:* This attribute is available as Technology Preview.
        /// These are early access APIs provided to test, automate and provide feedback on the feature. Since this can change based
        /// on feedback, VMware does not guarantee backwards compatibility and recommends against using them in production
        /// environments. Some Technology Preview APIs might only be applicable to specific environments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "current_session_info")]
        public VcenterHvcLinksSyncProvidersSessionInfoType CurrentSessionInfo { get; set; }
        /// <summary>
        /// Localizable messages associated with sync status *Warning:* This attribute is available as Technology Preview. These are
        /// early access APIs provided to test, automate and provide feedback on the feature. Since this can change based on
        /// feedback, VMware does not guarantee backwards compatibility and recommends against using them in production
        /// environments. Some Technology Preview APIs might only be applicable to specific environments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status_message")]
        public VapiStdLocalizableMessageTypeA StatusMessage { get; set; }
    }
}
