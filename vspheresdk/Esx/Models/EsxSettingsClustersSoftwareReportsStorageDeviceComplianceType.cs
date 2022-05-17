using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Esx.Models.Enums;

namespace vspheresdk.Esx.Models
{
    public class EsxSettingsClustersSoftwareReportsStorageDeviceComplianceType 
    {
        /// <summary>
        /// Overall compliance status of storage devices in the cluster with respect to all hosts in the cluster.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public EsxSettingsClustersSoftwareReportsComplianceStatusEnumType Status { get; set; }
        /// <summary>
        /// Lists compliance information for storage devices found to be compliant with VMware Compatibility Guide (VCG) during the
        /// last check {@term operation}. <p> Note that complianceStatus of every device is not necessarily COMPATIBLE due to
        /// changes made after this check was run; entries are only rearranged when a new check {@term operation} is invoked. {@link
        /// lastOverrideTime} being greater than the {@link scanTime} is an indication that there were changes made after the last
        /// check {@term operation}
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "compatible_devices", Required = Required.AllowNull)]
        public Dictionary<string,EsxSettingsClustersSoftwareReportsStorageDeviceComplianceInfoType> CompatibleDevices { get; set; }
        /// <summary>
        /// Lists compliance information for storage devices found to be non-compliant with VMware Compatibility Guide (VCG) during
        /// the last check {@term operation}. <p> Note that complianceStatus of every device is not necessarily INCOMPATIBLE due to
        /// changes made after this check was run; entries are only rearranged when a new check {@term operation} is invoked. {@link
        /// lastOverrideTime} being greater than the {@link scanTime} is an indication that there were changes made after the last
        /// check {@term operation}
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "incompatible_devices", Required = Required.AllowNull)]
        public Dictionary<string,EsxSettingsClustersSoftwareReportsStorageDeviceComplianceInfoType> IncompatibleDevices { get; set; }
        /// <summary>
        /// Lists storage devices whose compliance information could not be computed successfully during the last check {@term
        /// operation}. <p> Note that complianceStatus of every device is not necessarily UNAVAILABLE due to changes made after this
        /// check was run; entries are only rearranged when a new check {@term operation} is invoked. {@link lastOverrideTime} being
        /// greater than the {@link scanTime} is an indication that there were changes made after the last check {@term operation}
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "unknown_devices", Required = Required.AllowNull)]
        public Dictionary<string,EsxSettingsClustersSoftwareReportsStorageDeviceComplianceInfoType> UnknownDevices { get; set; }
        /// <summary>
        /// Storage device compliance specific notifications describing the compliance result.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "notifications")]
        public EsxSettingsNotificationsType Notifications { get; set; }
    }
}
