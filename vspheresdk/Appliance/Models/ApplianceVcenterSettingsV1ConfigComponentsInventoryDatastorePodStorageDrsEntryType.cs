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
    public class ApplianceVcenterSettingsV1ConfigComponentsInventoryDatastorePodStorageDrsEntryType 
    {
        /// <summary>
        /// Storage DRS configuration.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "storage_drs_config", Required = Required.AllowNull)]
        public ApplianceVcenterSettingsV1ConfigComponentsInventoryDatastoreStorageDrsConfigInfoType StorageDrsConfig { get; set; }
    }
}
