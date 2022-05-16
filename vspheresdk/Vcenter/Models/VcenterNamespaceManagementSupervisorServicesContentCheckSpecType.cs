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
    public class VcenterNamespaceManagementSupervisorServicesContentCheckSpecType 
    {
        /// <summary>
        /// The content of a Supervisor Service version, which shall be base64 encoded.
        /// If unset, the content shall be provided separately. In the current release, this field is required, otherwise
        /// InvalidArgument will be thrown.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "content")]
        public string? Content { get; set; }
    }
}
