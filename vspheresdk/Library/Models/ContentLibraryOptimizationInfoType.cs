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
    public class ContentLibraryOptimizationInfoType 
    {
        /// <summary>
        /// If set to {@code true} then library would be optimized for remote publishing. <p> Turn it on if remote publishing is
        /// dominant use case for this library. Remote publishing means here that publisher and subscribers are not the part of the
        /// same {@name Vcenter} SSO domain. <p> Any optimizations could be done as result of turning on this optimization during
        /// library creation. For example, library content could be stored in different format but optimizations are not limited to
        /// just storage format. <p> Note, that value of this toggle could be set only during creation of the library and you would
        /// need to migrate your library in case you need to change this value (optimize the library for different use case).
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "optimize_remote_publishing")]
        public bool? OptimizeRemotePublishing { get; set; }
    }
}
