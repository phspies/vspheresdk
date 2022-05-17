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
    public class EsxHclHostsCompatibilityReportDeviceConstraintType 
    {
        /// <summary>
        /// The driver information about the constraint.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "driver", Required = Required.AllowNull)]
        public EsxHclDriverType Driver { get; set; }
        /// <summary>
        /// The firmware information about the constraint.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "firmware")]
        public EsxHclFirmwareType Firmware { get; set; }
        /// <summary>
        /// Any information that should be taken into account when reviewing the device constraint.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "notes", Required = Required.AllowNull)]
        public Dictionary<string,VapiStdLocalizableMessageType> Notes { get; set; }
    }
}
