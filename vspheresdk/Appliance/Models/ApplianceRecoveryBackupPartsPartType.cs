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
    public class ApplianceRecoveryBackupPartsPartType 
    {
        /// <summary>
        /// part ID
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// appliance.recovery.backup.parts. When operations return a value of this structure as a result, the field will be an
        /// identifier for the resource type: appliance.recovery.backup.parts.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "id", Required = Required.AllowNull)]
        public string Id { get; set; }
        /// <summary>
        /// part name id in message bundle
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public ApplianceRecoveryBackupPartsLocalizableMessageType Name { get; set; }
        /// <summary>
        /// part description id in message bundle
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description", Required = Required.AllowNull)]
        public ApplianceRecoveryBackupPartsLocalizableMessageType Description { get; set; }
        /// <summary>
        /// Is this part selected by default in the user interface.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "selected_by_default", Required = Required.AllowNull)]
        public bool SelectedByDefault { get; set; }
        /// <summary>
        /// Is this part optional.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "optional", Required = Required.AllowNull)]
        public bool Optional { get; set; }
    }
}
