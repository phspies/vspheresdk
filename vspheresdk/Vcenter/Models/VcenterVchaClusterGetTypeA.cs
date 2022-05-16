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
    public class VcenterVchaClusterGetTypeA 
    {
        /// <summary>
        /// Contains active node's management vCenter server credentials.
        /// If unset, then the active vCenter Server instance is assumed to be either self-managed or else in enhanced linked mode
        /// and managed by a linked vCenter Server instance.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vc_spec")]
        public VcenterVchaCredentialsSpecTypeA VcSpec { get; set; }
        /// <summary>
        /// If true, then return only the information that does not require connecting to the Active vCenter Server.
        /// If false or unset, then return all the information.
        /// If unset, then return all the information.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "partial")]
        public bool? Partial { get; set; }
    }
}
