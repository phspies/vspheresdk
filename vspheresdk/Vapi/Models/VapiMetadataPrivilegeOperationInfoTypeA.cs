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
    public class VapiMetadataPrivilegeOperationInfoTypeA 
    {
        /// <summary>
        /// List of all privileges assigned to the operation element.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "privileges", Required = Required.AllowNull)]
        public IList<string> Privileges { get; set; }
        /// <summary>
        /// Privilege information of all the parameter elements of the operation element. For an explanation of containment of
        /// privilege information within parameter elements, see {@link vapi.metadata.privilege.PrivilegeInfo}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "privilege_info", Required = Required.AllowNull)]
        public Dictionary<string,VapiMetadataPrivilegePrivilegeInfoTypeA> PrivilegeInfo { get; set; }
    }
}
