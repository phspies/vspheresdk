using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Vapi.Models.Enums;

namespace vspheresdk.Vapi.Models
{
    public class VapiMetadataAuthenticationPackageInfoTypeA 
    {
        /// <summary>
        /// List of authentication schemes to be used for all the operation elements contained in this package element. If a
        /// particular service or operation element has no explicit authentications defined in the authentication defintion file,
        /// these authentication schemes are used for authenticating the user.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "schemes", Required = Required.AllowNull)]
        public Dictionary<string,VapiMetadataAuthenticationAuthenticationInfoTypeA> Schemes { get; set; }
        /// <summary>
        /// Information about all service elements contained in this package element that contain authentication information. The
        /// key in the {@term map} is the identifier of the service element and the value in the {@term map} is the authentication
        /// information for the service element. <p> For an explanation of authentication information containment within service
        /// elements, see {@link vapi.metadata.authentication.Service}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "services", Required = Required.AllowNull)]
        public IList<object> Services { get; set; }
    }
}
