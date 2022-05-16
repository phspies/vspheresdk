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
    public class VcenterOvfLibraryItemResultInfoTypeA 
    {
        /// <summary>
        /// Errors reported by the {@name LibraryItem#create} or {@name LibraryItem#deploy} {@term operation}. These errors would
        /// have prevented the {@name LibraryItem#create} or {@name LibraryItem#deploy} {@term operation} from completing
        /// successfully.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "errors", Required = Required.AllowNull)]
        public Dictionary<string,VcenterOvfOvfErrorTypeA> Errors { get; set; }
        /// <summary>
        /// Warnings reported by the {@name LibraryItem#create} or {@name LibraryItem#deploy} {@term operation}. These warnings
        /// would not have prevented the {@name LibraryItem#create} or {@name LibraryItem#deploy} {@term operation} from completing
        /// successfully, but there might be issues that warrant attention.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "warnings", Required = Required.AllowNull)]
        public Dictionary<string,VcenterOvfOvfWarningTypeA> Warnings { get; set; }
        /// <summary>
        /// Information messages reported by the {@name LibraryItem#create} or {@name LibraryItem#deploy} {@term operation}. For
        /// example, a non-required parameter was ignored.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "information", Required = Required.AllowNull)]
        public Dictionary<string,VcenterOvfOvfInfoTypeA> Information { get; set; }
    }
}
