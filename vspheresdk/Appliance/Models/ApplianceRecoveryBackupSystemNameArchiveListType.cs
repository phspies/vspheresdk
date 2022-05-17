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
    public class ApplianceRecoveryBackupSystemNameArchiveListType 
    {
        /// <summary>
        /// LocationSpec Structure.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "loc_spec", Required = Required.AllowNull)]
        public ApplianceRecoveryBackupLocationSpecType LocSpec { get; set; }
        /// <summary>
        /// Specification of matching backups for which information should be returned.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "filter_spec", Required = Required.AllowNull)]
        public ApplianceRecoveryBackupSystemNameArchiveFilterSpecType FilterSpec { get; set; }
    }
}
