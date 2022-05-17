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
    public class VapiMetadataPrivilegeComponentInfoType 
    {
        /// <summary>
        /// Privilege information of all the package elements. The key in the {@term map} is the identifier of the package element
        /// and the value in the {@term map} is the privilege information for the package element. <p> For an explanation of
        /// privilege information containment within package elements, see {@link vapi.metadata.privilege.Package}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "packages", Required = Required.AllowNull)]
        public Dictionary<string,VapiMetadataPrivilegePackageInfoType> Packages { get; set; }
    }
}
