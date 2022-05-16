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
    public class VcenterOvfLibraryItemCreateTargetType 
    {
        /// <summary>
        /// Identifier of the library in which a new library item should be created. This {@term field} is not used if the {@name
        /// #libraryItemId} {@term field} is specified.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "library_id")]
        public string? LibraryId { get; set; }
        /// <summary>
        /// Identifier of the library item that should be should be updated.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "library_item_id")]
        public string? LibraryItemId { get; set; }
    }
}
