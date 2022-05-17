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
    public class VapiMetadataPrivilegePackageInfoTypeA 
    {
        /// <summary>
        /// List of default privileges to be used for all the operations present in this package. If a particular operation element
        /// has no explicit privileges defined in the privilege definition file, these privileges are used for enforcing
        /// authorization.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "privileges", Required = Required.AllowNull)]
        public IList<string> Privileges { get; set; }
        /// <summary>
        /// Information about all service elements contained in this package element that contain privilege information. The key in
        /// the {@term map} is the identifier of the service element and the value in the {@term map} is the privilege information
        /// for the service element. For an explanation of privilege information containment within service elements, see {@link
        /// vapi.metadata.privilege.Service}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "services", Required = Required.AllowNull)]
        public IList<object> Services { get; set; }
    }
}
