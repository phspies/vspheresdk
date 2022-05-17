using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Esx.Models.Enums;

namespace vspheresdk.Esx.Models
{
    public class EsxSettingsHardwareSupportManagersHardwareSupportManagerInfoType 
    {
        /// <summary>
        /// Name of the Hardware Support Manager (HSM) (e.g. "Frobozz Hardware Support Manager")
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "manager", Required = Required.AllowNull)]
        public string Manager { get; set; }
        /// <summary>
        /// User-intelligible description of the HSM (e.g. "Front end for Frobozz so-and-so management system")
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description", Required = Required.AllowNull)]
        public string Description { get; set; }
        /// <summary>
        /// UI label for HSM, derived from HSM extension's description's 'label' field. (e.g. "Frobozz Free Management System")
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "display_name", Required = Required.AllowNull)]
        public string DisplayName { get; set; }
        /// <summary>
        /// Company providing the Hardware Support Manager (HSM) (e.g. "Frobozz Magic Software Company")
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vendor", Required = Required.AllowNull)]
        public string Vendor { get; set; }
    }
}
