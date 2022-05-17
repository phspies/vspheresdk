using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Hvc.Models.Enums;

namespace vspheresdk.Hvc.Models
{
    public class VapiStdLocalizationParamType 
    {
        /// <summary>
        /// {@term String} value associated with the parameter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "s")]
        public string? S { get; set; }
        /// <summary>
        /// Date and time value associated with the parameter. Use the {@name #format} {@term field} to specify date and time
        /// display style.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "dt")]
        public DateTime? Dt { get; set; }
        /// <summary>
        /// {@term long} value associated with the parameter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "i")]
        public long? I { get; set; }
        /// <summary>
        /// The {@term double} value associated with the parameter. The number of displayed fractional digits is changed via {@name
        /// #precision} {@term field}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "d")]
        public double? D { get; set; }
        /// <summary>
        /// Nested localizable value associated with the parameter. This is useful construct to convert to human readable localized
        /// form {@term enumerated type} and {@term boolean} values. It can also be used for proper handling of pluralization and
        /// gender forms in localization. Recursive {@name NestedLocalizableMessage} instances can be used for localizing short
        /// lists of items.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "l")]
        public VapiStdNestedLocalizableMessageType L { get; set; }
        /// <summary>
        /// Format associated with the date and time value in {@name #dt} {@term field}. The {@term enumeration value} {@code
        /// SHORT_DATETIME} will be used as default.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "format")]
        public VapiStdLocalizationParamDateTimeFormatType Format { get; set; }
        /// <summary>
        /// Number of fractional digits to include in formatted {@term double} value.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "precision")]
        public long? Precision { get; set; }
    }
}
