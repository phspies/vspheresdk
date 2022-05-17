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
    public class EsxHclCompatibilityDataStatusType 
    {
        /// <summary>
        /// Indicates when the data was last updated.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "updated_at", Required = Required.AllowNull)]
        public DateTime UpdatedAt { get; set; }
        /// <summary>
        /// Notifications returned by the operation.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "notifications", Required = Required.AllowNull)]
        public EsxHclNotificationsType Notifications { get; set; }
    }
}
