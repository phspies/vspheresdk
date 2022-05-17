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
    public class ApplianceUpdatePendingInfoType 
    {
        /// <summary>
        /// Name of the update.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// List of the 1. issues addressed since previous/current version 2. new features/improvements
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "contents", Required = Required.AllowNull)]
        public Dictionary<string,VapiStdLocalizableMessageType> Contents { get; set; }
        /// <summary>
        /// List of the services that will be stopped and restarted during the update installation.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "services_will_be_stopped", Required = Required.AllowNull)]
        public Dictionary<string,ApplianceUpdateServiceInfoType> ServicesWillBeStopped { get; set; }
        /// <summary>
        /// List of EULAs. This list has multiple entries and can be dynamic based on what we are actually installing.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "eulas", Required = Required.AllowNull)]
        public Dictionary<string,VapiStdLocalizableMessageType> Eulas { get; set; }
        /// <summary>
        /// Is the update staged
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "staged", Required = Required.AllowNull)]
        public bool Staged { get; set; }
        /// <summary>
        /// URL for the knowledge base article describing this update.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "knowledge_base", Required = Required.AllowNull)]
        public string KnowledgeBase { get; set; }
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
        public ApplianceUpdateCommonInfoPriorityType Priority { get; set; }
        /// <summary>
        /// Update severity
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "severity", Required = Required.AllowNull)]
        public ApplianceUpdateCommonInfoSeverityType Severity { get; set; }
        /// <summary>
        /// Update category
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "update_type", Required = Required.AllowNull)]
        public ApplianceUpdateCommonInfoCategoryType UpdateType { get; set; }
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
