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
    public class VapiMetadataPrivilegeServiceInfoTypeA 
    {
        /// <summary>
        /// Information about all operation elements contained in this service element that contain privilege information. The key
        /// in the {@term map} is the identifier of the operation element and the value in the {@term map} is the privilege
        /// information for the operation element. <p> For an explanation of containment of privilege information within operation
        /// elements, see {@link vapi.metadata.privilege.service.Operation}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "operations", Required = Required.AllowNull)]
        public IList<object> Operations { get; set; }
    }
}
