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
    public class VcenterNamespaceManagementSupervisorServicesVersionsVsphereCreateSpecType 
    {
        /// <summary>
        /// Inline content that contains all service definition of the version in vSphere application service format, which shall be
        /// base64 encoded.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "content", Required = Required.AllowNull)]
        public string Content { get; set; }
        /// <summary>
        /// Whether or not the Supervisor Service version is from a trusted provider, this field must be set to false if the service
        /// version is not from a trusted provider. If it is set to be true, but the Versions.VsphereCreateSpec.content is not
        /// signed or the signature is invalid, an InvalidArgument will be thrown.
        /// If unset, the default value is true. In this case, the Versions.VsphereCreateSpec.content must be signed and will be
        /// verified.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "trusted_provider")]
        public bool? TrustedProvider { get; set; }
        /// <summary>
        /// Whether or not the End User License Agreement (EULA) that is specified in the Versions.VsphereCreateSpec.content is
        /// accepted. If a EULA is specified, this field must be set to be true so that the Supervisor Service version can be
        /// created.
        /// If unset, the default value is false.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "accept_EULA")]
        public bool? AcceptEULA { get; set; }
    }
}
