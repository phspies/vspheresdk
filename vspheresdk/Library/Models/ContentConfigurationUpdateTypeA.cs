using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Library.Models.Enums;

namespace vspheresdk.Library.Models
{
    public class ContentConfigurationUpdateTypeA 
    {
        /// <summary>
        /// The {@link ConfigurationModel} specifying the settings to update.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "model", Required = Required.AllowNull)]
        public ContentConfigurationModelTypeA Model { get; set; }
    }
}
