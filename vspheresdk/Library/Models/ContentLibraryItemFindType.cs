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
    public class ContentLibraryItemFindType 
    {
        /// <summary>
        /// The name of the library item. The name is case-insensitive. See {@link ItemModel#name}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// The identifier of the library containing the item. See {@link ItemModel#libraryId}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "library_id")]
        public string? LibraryId { get; set; }
        /// <summary>
        /// The identifier of the library item as reported by the publisher. See {@link ItemModel#sourceId}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "source_id")]
        public string? SourceId { get; set; }
        /// <summary>
        /// The type of the library item. The type is case-insensitive. See {@link ItemModel#type}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string? Type { get; set; }
        /// <summary>
        /// Whether the item is cached. Possible values are 'true' or 'false'. See {@link ItemModel#cached}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cached")]
        public bool? Cached { get; set; }
    }
}
