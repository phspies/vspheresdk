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
    public class VcenterVmGuestCustomizationInfoType 
    {
        /// <summary>
        /// The status of the customization operation.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public VcenterVmGuestCustomizationInfoStatusType Status { get; set; }
        /// <summary>
        /// Description of the error if the Customization.Info.status of customization operation is FAILED.
        /// This field will be unset if the status is not FAILED or there is no information available for the error.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public string? Error { get; set; }
        /// <summary>
        /// Time when the customization process has started inside the guest operating system.
        /// This field will be unset if the status is PENDING.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "start_time")]
        public DateTime? StartTime { get; set; }
        /// <summary>
        /// Time when the customization process has completed inside the guest operating system.
        /// This field will be unset if the status is not SUCCEEDED or FAILED.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "end_time")]
        public DateTime? EndTime { get; set; }
    }
}
