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
    public class VcenterDeploymentHistoryMigrationSpecType 
    {
        /// <summary>
        /// Defines what part of vCenter historical data will be migrated along with core data.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "data_set", Required = Required.AllowNull)]
        public VcenterDeploymentHistoryMigrationOptionEnumType DataSet { get; set; }
        /// <summary>
        /// Defines how vCenter history will be migrated. If set to true, vCenter history will be migrated separately after
        /// successful upgrade(supported scenarios are upgrade from 6.0 or 6.5 to 6.7) or migration, otherwise it will be migrated
        /// along with core data during the upgrade or migration process. vCSA upgrade with deferred import is no longer supported
        /// for target version 7.0 and later.
        /// If unset, vCenter historical data won't be deferred and will be migrated along with core data.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "defer_import")]
        public bool? DeferImport { get; set; }
    }
}
