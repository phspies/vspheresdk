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
    public class VapiMetadataAuthenticationServiceInfoType 
    {
        /// <summary>
        /// List of authentication schemes to be used for all the operation elements contained in this service element. The
        /// authentication scheme specified on the package element corresponding to this service element is ignored.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "schemes", Required = Required.AllowNull)]
        public Dictionary<string,VapiMetadataAuthenticationAuthenticationInfoType> Schemes { get; set; }
        /// <summary>
        /// Information about all operation elements contained in this service element that contain authentication information. The
        /// key in the {@term map} is the identifier of the operation element and the value in the {@term map} is the authentication
        /// information for the operation element. <p> For an explanation of containment of authentication information within
        /// operation elements, see {@link vapi.metadata.authentication.service.Operation}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "operations", Required = Required.AllowNull)]
        public Dictionary<string,VapiMetadataAuthenticationOperationInfoType> Operations { get; set; }
    }
}
