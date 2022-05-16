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
    public class VcenterOvfExportFlagInfoType 
    {
        /// <summary>
        /// The name of the export flag that is supported by the server.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "option", Required = Required.AllowNull)]
        public string Option { get; set; }
        /// <summary>
        /// Localizable description of the export flag.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description", Required = Required.AllowNull)]
        public VapiStdLocalizableMessageType Description { get; set; }
    }
}
