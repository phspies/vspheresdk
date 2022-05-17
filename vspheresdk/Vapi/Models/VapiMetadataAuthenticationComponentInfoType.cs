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
    public class VapiMetadataAuthenticationComponentInfoType 
    {
        /// <summary>
        /// Authentication information of all the package elements. The key in the {@term map} is the identifier of the package
        /// element and the value in the {@term map} is the authentication information for the package element. <p> For an
        /// explanation of authentication information containment within package elements, see {@link
        /// vapi.metadata.authentication.Package}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "packages", Required = Required.AllowNull)]
        public Dictionary<string,VapiMetadataAuthenticationPackageInfoType> Packages { get; set; }
    }
}
