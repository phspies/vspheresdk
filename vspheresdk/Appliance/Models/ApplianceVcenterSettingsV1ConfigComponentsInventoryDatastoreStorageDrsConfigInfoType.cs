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
    public class ApplianceVcenterSettingsV1ConfigComponentsInventoryDatastoreStorageDrsConfigInfoType 
    {
        /// <summary>
        /// Pod-wide configuration information for the storage DRS service.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "pod_config", Required = Required.AllowNull)]
        public ApplianceVcenterSettingsV1ConfigComponentsInventoryDatastoreStorageDrsPodConfigInfoType PodConfig { get; set; }
    }
}
