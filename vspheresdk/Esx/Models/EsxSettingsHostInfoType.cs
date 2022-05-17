using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Esx.Models.Enums;

namespace vspheresdk.Esx.Models
{
    public class EsxSettingsHostInfoType 
    {
        /// <summary>
        /// Name of the host.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Indicates if the host is associated with a cluster as a vSAN witness.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "is_vsan_witness")]
        public bool? IsVsanWitness { get; set; }
    }
}
