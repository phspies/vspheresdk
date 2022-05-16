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
    public class VcenterGuestCustomizationSpecsInfoType 
    {
        /// <summary>
        /// Time when the specification was last modified.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "last_modified", Required = Required.AllowNull)]
        public DateTime LastModified { get; set; }
        /// <summary>
        /// The Spec object including specification and metadata information.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "spec", Required = Required.AllowNull)]
        public VcenterGuestCustomizationSpecsSetType Spec { get; set; }
    }
}
