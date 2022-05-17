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
    public class EsxHclHostsCompatibilityReportBiosConstraintType 
    {
        /// <summary>
        /// The BIOS information about the constraint.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "bios", Required = Required.AllowNull)]
        public EsxHclFirmwareType Bios { get; set; }
        /// <summary>
        /// Any information that should be taken into account when reviewing the BIOS constraint.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "notes", Required = Required.AllowNull)]
        public Dictionary<string,VapiStdLocalizableMessageType> Notes { get; set; }
    }
}
