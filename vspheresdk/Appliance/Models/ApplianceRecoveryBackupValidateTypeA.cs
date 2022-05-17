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
    public class ApplianceRecoveryBackupValidateTypeA 
    {
        /// <summary>
        /// BackupRequest Structure
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "piece", Required = Required.AllowNull)]
        public ApplianceRecoveryBackupBackupRequestTypeA Piece { get; set; }
    }
}
