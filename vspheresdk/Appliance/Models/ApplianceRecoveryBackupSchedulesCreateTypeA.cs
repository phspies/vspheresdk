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
    public class ApplianceRecoveryBackupSchedulesCreateTypeA 
    {
        /// <summary>
        /// CreateSpec Structure
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "spec", Required = Required.AllowNull)]
        public ApplianceRecoveryBackupSchedulesCreateSpecTypeA Spec { get; set; }
    }
}
