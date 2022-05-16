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
    public class VcenterVmGuestFilesystemFilesIterationSpecType 
    {
        /// <summary>
        /// Specifies the maximum number of results to return.
        /// If unset information about at most 50 files will be returned.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public long? Size { get; set; }
        /// <summary>
        /// Which result to start the list with. If this value exceeds the number of results, an empty list will be returned.
        /// If unset, the start of the list of files will be returned.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "index")]
        public long? Index { get; set; }
    }
}
