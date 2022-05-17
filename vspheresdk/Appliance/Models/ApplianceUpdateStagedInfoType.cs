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
    public class ApplianceUpdateStagedInfoType 
    {
        /// <summary>
        /// Is staging complete
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "staging_complete", Required = Required.AllowNull)]
        public bool StagingComplete { get; set; }
        /// <summary>
        /// Version in form of X.Y.Z.P. e.g. 6.5.1.5400
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// appliance.update.pending. When operations return a value of this structure as a result, the field will be an identifier
        /// for the resource type: appliance.update.pending.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "version", Required = Required.AllowNull)]
        public string Version { get; set; }
        /// <summary>
        /// Name of the update.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Description of the update. The short information what this update is. E.g. "Update2 for vCenter Server Appliance 6.5"
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description", Required = Required.AllowNull)]
        public VapiStdLocalizableMessageType Description { get; set; }
        /// <summary>
        /// Update priority
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "priority", Required = Required.AllowNull)]
        public ApplianceUpdateCommonInfoPriorityEnumType Priority { get; set; }
        /// <summary>
        /// Update severity
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "severity", Required = Required.AllowNull)]
        public ApplianceUpdateCommonInfoSeverityEnumType Severity { get; set; }
        /// <summary>
        /// Update category
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "update_type", Required = Required.AllowNull)]
        public ApplianceUpdateCommonInfoCategoryEnumType UpdateType { get; set; }
        /// <summary>
        /// Update release date.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "release_date", Required = Required.AllowNull)]
        public DateTime ReleaseDate { get; set; }
        /// <summary>
        /// Flag indicating whether reboot is required after update.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "reboot_required", Required = Required.AllowNull)]
        public bool RebootRequired { get; set; }
        /// <summary>
        /// Download Size of update in Megabytes.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "size", Required = Required.AllowNull)]
        public long Size { get; set; }
    }
}
