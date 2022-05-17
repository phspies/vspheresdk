using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Appliance.Models.Enums;

namespace vspheresdk.Appliance.Models
{
    public class ApplianceSupportBundleInfoType 
    {
        /// <summary>
        /// Support bundle creation description.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description", Required = Required.AllowNull)]
        public string Description { get; set; }
        /// <summary>
        /// Status of the task
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public ApplianceSupportBundleCreationStatusEnumType Status { get; set; }
        /// <summary>
        /// Support bundle generation time.
        /// This field is optional and it is only relevant when the value of SupportBundle.Info.status is SUCCEEDED.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "generation_time")]
        public DateTime? GenerationTime { get; set; }
        /// <summary>
        /// Support bundle downlooad URL.
        /// This field is optional and it is only relevant when the value of SupportBundle.Info.status is SUCCEEDED.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string? Url { get; set; }
        /// <summary>
        /// Download expiration time.
        /// This field is optional and it is only relevant when the value of SupportBundle.Info.status is SUCCEEDED.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "expiration_time")]
        public DateTime? ExpirationTime { get; set; }
        /// <summary>
        /// Support bundle availability for download.
        /// This field is optional and it is only relevant when the value of SupportBundle.Info.status is SUCCEEDED.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "downloadable")]
        public bool? Downloadable { get; set; }
        /// <summary>
        /// Support bundle file size in KBs.
        /// This field is optional and it is only relevant when the value of SupportBundle.Info.status is SUCCEEDED.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public long? Size { get; set; }
        /// <summary>
        /// Reason for failure
        /// This field is optional and it is only relevant when the value of SupportBundle.Info.status is FAILED.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "failure_reason")]
        public VapiStdLocalizableMessageType FailureReason { get; set; }
    }
}
