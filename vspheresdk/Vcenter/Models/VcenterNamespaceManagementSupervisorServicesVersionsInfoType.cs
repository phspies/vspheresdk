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
    public class VcenterNamespaceManagementSupervisorServicesVersionsInfoType 
    {
        /// <summary>
        /// The human readable name of the Supervisor Service version.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "display_name", Required = Required.AllowNull)]
        public string DisplayName { get; set; }
        /// <summary>
        /// A human-readable description of the Supervisor Service version.
        /// If unset, no description is available for the Supervisor Service version.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// The End User License Agreement (EULA) associated with the Supervisor Service version.
        /// If unset, no EULA is available for the Supervisor Service version.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "EULA")]
        public string? EULA { get; set; }
        /// <summary>
        /// The content type of Versions.Info.content.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "content_type", Required = Required.AllowNull)]
        public VcenterNamespaceManagementSupervisorServicesVersionsContentTypeEnum ContentType { get; set; }
        /// <summary>
        /// Inline content that contains base64 encoded service definition for the version.
        /// If unset, no content is available for the Supervisor Service version.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "content")]
        public string? Content { get; set; }
        /// <summary>
        /// If true, the Supervisor Service version is from trusted provider and the trust is verified.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "trust_verified", Required = Required.AllowNull)]
        public bool TrustVerified { get; set; }
        /// <summary>
        /// The current Versions.State of the version.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "state", Required = Required.AllowNull)]
        public VcenterNamespaceManagementSupervisorServicesVersionsStateEnumType State { get; set; }
    }
}
