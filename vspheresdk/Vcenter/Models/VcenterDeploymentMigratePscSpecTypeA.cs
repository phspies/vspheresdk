using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Vcenter.Models.Enums;

namespace vspheresdk.Vcenter.Models
{
    public class VcenterDeploymentMigratePscSpecTypeA 
    {
        /// <summary>
        /// Customer experience improvement program should be enabled or disabled for this Platform Services Controller migration.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ceip_enabled", Required = Required.AllowNull)]
        public bool CeipEnabled { get; set; }
    }
}
