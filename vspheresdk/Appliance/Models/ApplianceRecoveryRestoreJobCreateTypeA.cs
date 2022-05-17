using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Appliance.Models.Enums;

namespace vspheresdk.Appliance.Models
{
    public class ApplianceRecoveryRestoreJobCreateTypeA 
    {
        /// <summary>
        /// RestoreRequest Structure
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "piece", Required = Required.AllowNull)]
        public ApplianceRecoveryRestoreJobRestoreRequestTypeA Piece { get; set; }
    }
}
