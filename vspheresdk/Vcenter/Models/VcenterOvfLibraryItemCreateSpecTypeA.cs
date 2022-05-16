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
    public class VcenterOvfLibraryItemCreateSpecTypeA 
    {
        /// <summary>
        /// Name to use in the OVF descriptor stored in the library item.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Description to use in the OVF descriptor stored in the library item.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Flags to use for OVF package creation. The supported flags can be obtained using {@link ExportFlag#list}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "flags")]
        public IList<string> Flags { get; set; }
    }
}
