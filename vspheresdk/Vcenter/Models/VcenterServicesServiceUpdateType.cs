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
    public class VcenterServicesServiceUpdateType 
    {
        /// <summary>
        /// Startup Type
        /// If unspecified, leaves value unchanged.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "startup_type")]
        public VcenterServicesServiceStartupType StartupType { get; set; }
    }
}
