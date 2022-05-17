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
    public class EsxSettingsDepotsUmdsContentInfoType 
    {
        /// <summary>
        /// A list of metadata bundles contained in the depot. The key is vendor of metadata bundle.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "metadata_bundles", Required = Required.AllowNull)]
        public object MetadataBundles { get; set; }
    }
}
