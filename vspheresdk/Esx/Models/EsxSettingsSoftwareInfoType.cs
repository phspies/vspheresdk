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
    public class EsxSettingsSoftwareInfoType 
    {
        /// <summary>
        /// Base image of the ESX.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "base_image", Required = Required.AllowNull)]
        public EsxSettingsBaseImageInfoType BaseImage { get; set; }
        /// <summary>
        /// OEM customization on top of given base-image. The components in this customization override the components in the base
        /// base-image.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "add_on")]
        public EsxSettingsAddOnInfoType AddOn { get; set; }
        /// <summary>
        /// Information about the components in the software specification.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "components", Required = Required.AllowNull)]
        public Dictionary<string,EsxSettingsComponentInfoType> Components { get; set; }
        /// <summary>
        /// Information about the solutions in the software specification.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutions", Required = Required.AllowNull)]
        public Dictionary<string,EsxSettingsSolutionInfoType> Solutions { get; set; }
        /// <summary>
        /// Information about the Hardware Support Packages (HSP) configured.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "hardware_support")]
        public EsxSettingsHardwareSupportInfoType HardwareSupport { get; set; }
    }
}
