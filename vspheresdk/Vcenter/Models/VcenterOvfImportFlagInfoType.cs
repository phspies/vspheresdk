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
    public class VcenterOvfImportFlagInfoType 
    {
        /// <summary>
        /// The name of the import flag that is supported by the deployment platform.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "option", Required = Required.AllowNull)]
        public string Option { get; set; }
        /// <summary>
        /// Localizable description of the import flag.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description", Required = Required.AllowNull)]
        public VapiStdLocalizableMessageType Description { get; set; }
    }
}
