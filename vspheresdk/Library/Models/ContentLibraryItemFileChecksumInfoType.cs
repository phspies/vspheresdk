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
    public class ContentLibraryItemFileChecksumInfoType 
    {
        /// <summary>
        /// The checksum algorithm ({@enum.values ChecksumAlgorithm}) used to calculate the checksum.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "algorithm")]
        public ContentLibraryItemFileChecksumAlgorithmType Algorithm { get; set; }
        /// <summary>
        /// The checksum value calculated with {@link #algorithm}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "checksum", Required = Required.AllowNull)]
        public string Checksum { get; set; }
    }
}
