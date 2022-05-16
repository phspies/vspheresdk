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
    public class VcenterNamespaceManagementSupervisorServicesVersionsCustomCreateSpecType 
    {
        /// <summary>
        /// The identifier of the Supervisor Service version. This must be a semantic version.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vcenter.namespace_management.supervisor_services.Version. When operations return a value of this structure as a result,
        /// the field will be an identifier for the resource type: vcenter.namespace_management.supervisor_services.Version.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "version", Required = Required.AllowNull)]
        public string Version { get; set; }
        /// <summary>
        /// A human readable name of the Supervisor Service version.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "display_name", Required = Required.AllowNull)]
        public string DisplayName { get; set; }
        /// <summary>
        /// A human readable description of the Supervisor Service version.
        /// If unset, the description for the service version will be empty.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Inline content that contains all service definition of the version, which shall be base64 encoded. The service
        /// definition here follows a plain Kubernetes YAML format.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "content", Required = Required.AllowNull)]
        public string Content { get; set; }
        /// <summary>
        /// Whether or not the Supervisor Service version is from a trusted provider, this field must be set to false if the service
        /// version is not from a trusted provider. If it is set to be true, but the Versions.CustomCreateSpec.content is not signed
        /// or the signature is invalid, an InvalidArgument will be thrown.
        /// If unset, the default value is true. In this case, the Versions.CustomCreateSpec.content must be signed and will be
        /// verified.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "trusted_provider")]
        public bool? TrustedProvider { get; set; }
    }
}
