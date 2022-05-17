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
    public class VcenterLcmUpdatePendingInfoType 
    {
        /// <summary>
        /// Description of the vSphere update
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description", Required = Required.AllowNull)]
        public string Description { get; set; }
        /// <summary>
        /// Identifier of the given vSphere update
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vcenter.lcm.update.pending. When operations return a value of this structure as a result, the field will be an
        /// identifier for the resource type: vcenter.lcm.update.pending.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "pending_update", Required = Required.AllowNull)]
        public string PendingUpdate { get; set; }
        /// <summary>
        /// Version of the vSphere update or patch
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "version", Required = Required.AllowNull)]
        public string Version { get; set; }
        /// <summary>
        /// Release date of the vSphere update or patch
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "release_date", Required = Required.AllowNull)]
        public DateTime ReleaseDate { get; set; }
        /// <summary>
        /// Severity of the issues fixed in the vSphere update or patch
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "severity", Required = Required.AllowNull)]
        public VcenterLcmUpdatePendingSeverityTypeEnum Severity { get; set; }
        /// <summary>
        /// Build number of the vCenter Release
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "build", Required = Required.AllowNull)]
        public string Build { get; set; }
        /// <summary>
        /// Type of the Release based on the current vCenter version
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "update_type", Required = Required.AllowNull)]
        public VcenterLcmUpdatePendingUpdateTypeEnum UpdateType { get; set; }
        /// <summary>
        /// Category of the release based on features bundled on top of previous release
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "category", Required = Required.AllowNull)]
        public VcenterLcmUpdatePendingCategoryEnumType Category { get; set; }
        /// <summary>
        /// Flag to suggest a reboot after the release is applied
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "reboot_required", Required = Required.AllowNull)]
        public bool RebootRequired { get; set; }
        /// <summary>
        /// VAMI or ISO URL for update or upgrade execute phase redirection
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "execute_URL", Required = Required.AllowNull)]
        public string ExecuteURL { get; set; }
        /// <summary>
        /// List of URI pointing to patch or update release notes
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "release_notes", Required = Required.AllowNull)]
        public IList<string> ReleaseNotes { get; set; }
    }
}
