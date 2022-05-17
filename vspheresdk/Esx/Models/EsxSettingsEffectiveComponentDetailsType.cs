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
    public class EsxSettingsEffectiveComponentDetailsType 
    {
        /// <summary>
        /// Display name of the component.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "display_name", Required = Required.AllowNull)]
        public string DisplayName { get; set; }
        /// <summary>
        /// Human readable version of the component.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "display_version", Required = Required.AllowNull)]
        public string DisplayVersion { get; set; }
        /// <summary>
        /// Vendor of the component.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vendor", Required = Required.AllowNull)]
        public string Vendor { get; set; }
        /// <summary>
        /// Final effective source of the component.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "source", Required = Required.AllowNull)]
        public EsxSettingsComponentSourceEnumType Source { get; set; }
        /// <summary>
        /// Note assosicated with this component.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "note")]
        public VapiStdLocalizableMessageType Note { get; set; }
        /// <summary>
        /// List of other component versions present in base-image, add-ons or solutions that this component is overriding. For
        /// example, if a component version-1 was implicitly present in the base-image, but user wants it to be changed to
        /// version-2. In that case, {@link #source} would be USER and there will be one entry in this list indicating base-image
        /// component version-1 is being overridden.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "overridden_components", Required = Required.AllowNull)]
        public Dictionary<string,EsxSettingsComponentOverrideInfoType> OverriddenComponents { get; set; }
    }
}
