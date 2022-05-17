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
    public class VcenterGuestHostnameGeneratorTypeA 
    {
        /// <summary>
        /// The type of the Name Generator
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public VcenterGuestHostnameGeneratorTypeEnumA Type { get; set; }
        /// <summary>
        /// The virtual machine name specified by the client.
        /// This field is optional and it is only relevant when the value of HostnameGenerator.type is FIXED.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "fixed_name")]
        public string? FixedName { get; set; }
        /// <summary>
        /// Base prefix, to which a unique number is appended.
        /// This field is optional and it is only relevant when the value of HostnameGenerator.type is PREFIX.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "prefix")]
        public string? Prefix { get; set; }
    }
}
