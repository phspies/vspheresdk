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
    public class VcenterVmTemplateLibraryItemsCpuUpdateSpecType 
    {
        /// <summary>
        /// Number of virtual processors in the deployed virtual machine.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "num_cpus")]
        public long? NumCpus { get; set; }
        /// <summary>
        /// Number of cores among which to distribute CPUs in the deployed virtual machine.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "num_cores_per_socket")]
        public long? NumCoresPerSocket { get; set; }
    }
}
