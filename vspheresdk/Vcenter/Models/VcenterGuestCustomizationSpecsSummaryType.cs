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
    public class VcenterGuestCustomizationSpecsSummaryType 
    {
        /// <summary>
        /// Name of the guest customization specification.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vcenter.guest.CustomizationSpec. When operations return a value of this structure as a result, the field will be an
        /// identifier for the resource type: vcenter.guest.CustomizationSpec.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Description of the guest customization specification.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description", Required = Required.AllowNull)]
        public string Description { get; set; }
        /// <summary>
        /// Guest operating system type for which that this guest customization specification applies.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "OS_type", Required = Required.AllowNull)]
        public VcenterGuestCustomizationSpecsOsType OStype { get; set; }
        /// <summary>
        /// Date and tme when this guest customization specification was last modified.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "last_modified", Required = Required.AllowNull)]
        public DateTime LastModified { get; set; }
    }
}
