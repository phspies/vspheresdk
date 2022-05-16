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
    public class VcenterDeploymentDataMigrationEstimateTypeA 
    {
        /// <summary>
        /// The time estimated to export data from the source vCenter Server.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "estimated_export_time", Required = Required.AllowNull)]
        public long EstimatedExportTime { get; set; }
        /// <summary>
        /// The time estimated to import data to the upgraded vCenter Server.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "estimated_import_time", Required = Required.AllowNull)]
        public long EstimatedImportTime { get; set; }
        /// <summary>
        /// The extra free space required on source vCenter Server.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "required_free_disk_space_on_source", Required = Required.AllowNull)]
        public double RequiredFreeDiskSpaceOnSource { get; set; }
    }
}
