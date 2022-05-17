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
    public class EsxHclServerType 
    {
        /// <summary>
        /// The name of the server model (for example, "PowerEdge R740xd").
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "model_name", Required = Required.AllowNull)]
        public string ModelName { get; set; }
        /// <summary>
        /// The name of the vendor (for example, "Dell").
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vendor", Required = Required.AllowNull)]
        public string Vendor { get; set; }
        /// <summary>
        /// The CPU series name (for example, "Intel Xeon Gold 6100/5100, Silver 4100, Bronze 3100 (Skylake-SP) Series"). <p>
        /// <b>Note</b>: This {@term field} is initialized with the CPU <i>model</i> name; it's updated to the actual CPU series
        /// later, based on recognizing one of the CPU series the server hardware is certified with in the VCG.s
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cpu_series", Required = Required.AllowNull)]
        public string CpuSeries { get; set; }
        /// <summary>
        /// The current CPU features.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cpu_features", Required = Required.AllowNull)]
        public string CpuFeatures { get; set; }
        /// <summary>
        /// Currently installed BIOS of the server.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "bios", Required = Required.AllowNull)]
        public EsxHclFirmwareType Bios { get; set; }
    }
}
