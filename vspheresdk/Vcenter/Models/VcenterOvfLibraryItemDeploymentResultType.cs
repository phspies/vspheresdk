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
    public class VcenterOvfLibraryItemDeploymentResultType 
    {
        /// <summary>
        /// Whether the {@name LibraryItem#deploy} {@term operation} completed successfully.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "succeeded", Required = Required.AllowNull)]
        public bool Succeeded { get; set; }
        /// <summary>
        /// Identifier of the deployed resource entity.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "resource_id")]
        public VcenterOvfLibraryItemDeployableIdentityType ResourceId { get; set; }
        /// <summary>
        /// Errors, warnings, and informational messages produced by the {@name LibraryItem#deploy} {@term operation}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public VcenterOvfLibraryItemResultInfoType Error { get; set; }
    }
}
