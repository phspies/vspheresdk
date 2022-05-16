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
    public class VcenterOvfLibraryItemCreateResultType 
    {
        /// <summary>
        /// Whether the {@name LibraryItem#create} {@term operation} completed successfully.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "succeeded", Required = Required.AllowNull)]
        public bool Succeeded { get; set; }
        /// <summary>
        /// Identifier of the created or updated library item.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ovf_library_item_id")]
        public string? OvfLibraryItemId { get; set; }
        /// <summary>
        /// Errors, warnings, and informational messages produced by the {@name LibraryItem#create} {@term operation}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public VcenterOvfLibraryItemResultInfoType Error { get; set; }
    }
}
