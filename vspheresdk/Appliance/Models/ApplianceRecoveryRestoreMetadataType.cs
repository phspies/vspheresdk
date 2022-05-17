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
    public class ApplianceRecoveryRestoreMetadataType 
    {
        /// <summary>
        /// Time when this backup was completed.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "timestamp", Required = Required.AllowNull)]
        public DateTime Timestamp { get; set; }
        /// <summary>
        /// List of parts included in the backup.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "parts", Required = Required.AllowNull)]
        public IList<string> Parts { get; set; }
        /// <summary>
        /// VCSA version
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "version", Required = Required.AllowNull)]
        public string Version { get; set; }
        /// <summary>
        /// Box name is PNID/ FQDN etc
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "boxname", Required = Required.AllowNull)]
        public string Boxname { get; set; }
        /// <summary>
        /// Is SSO login required for the vCenter server.
        /// This field is optional because it was added in a newer version than its parent node.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "sso_login_required")]
        public bool? SsoLoginRequired { get; set; }
        /// <summary>
        /// Custom comment
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "comment", Required = Required.AllowNull)]
        public string Comment { get; set; }
        /// <summary>
        /// Does the VCSA match the deployment type, network properties and version of backed up VC
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "applicable", Required = Required.AllowNull)]
        public bool Applicable { get; set; }
        /// <summary>
        /// Any messages if the backup is not aplicable
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "messages", Required = Required.AllowNull)]
        public Dictionary<string,ApplianceRecoveryRestoreLocalizableMessageType> Messages { get; set; }
    }
}
