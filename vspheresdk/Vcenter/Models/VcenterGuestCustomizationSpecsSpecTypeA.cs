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
    public class VcenterGuestCustomizationSpecsSpecTypeA 
    {
        /// <summary>
        /// The fingerprint is a unique identifier for a given version of the configuration. Each change to the configuration will
        /// update this value. A client cannot change this value. If specified when updating a specification, the changes will only
        /// be applied if the current fingerprint matches the specified fingerprint. This field can be used to guard against updates
        /// that has happened between the specification content was read and until it is applied.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "fingerprint", Required = Required.AllowNull)]
        public string Fingerprint { get; set; }
        /// <summary>
        /// The specification object.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "spec", Required = Required.AllowNull)]
        public VcenterGuestCustomizationSpecTypeA Spec { get; set; }
        /// <summary>
        /// Description of the specification.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description", Required = Required.AllowNull)]
        public string Description { get; set; }
        /// <summary>
        /// Name of the specification.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
    }
}
