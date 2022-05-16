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
    public class VcenterVmGuestProcessesSummaryType 
    {
        /// <summary>
        /// The process name.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// The process ID.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "pid", Required = Required.AllowNull)]
        public long Pid { get; set; }
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
    }
}
