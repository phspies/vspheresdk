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
    public class VcenterVmGuestProcessesInfoType 
    {
        /// <summary>
        /// The process name.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// The process owner.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "owner", Required = Required.AllowNull)]
        public string Owner { get; set; }
        /// <summary>
        /// The full command line of the process.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "command", Required = Required.AllowNull)]
        public string Command { get; set; }
        /// <summary>
        /// The start time of the process.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "started", Required = Required.AllowNull)]
        public DateTime Started { get; set; }
        /// <summary>
        /// If the process was started using Processes.create then the process completion time will be available if queried within 5
        /// minutes after it completes.
        /// Set if the process was started with Processes.create and has recently exited.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "finished")]
        public DateTime? Finished { get; set; }
        /// <summary>
        /// If the process was started using Processes.create then the process exit code will be available if queried within 5
        /// minutes after it completes.
        /// Set if the process was started with Processes.create and has recently exited.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "exit_code")]
        public long? ExitCode { get; set; }
    }
}
