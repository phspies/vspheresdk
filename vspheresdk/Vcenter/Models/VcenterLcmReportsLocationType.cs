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
    public class VcenterLcmReportsLocationType 
    {
        /// <summary>
        /// Report Download URI.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "uri", Required = Required.AllowNull)]
        public string Uri { get; set; }
        /// <summary>
        /// Information about the token required in the HTTP GET request to retrieve the report
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "download_file_token", Required = Required.AllowNull)]
        public VcenterLcmReportsTokenType DownloadFileToken { get; set; }
    }
}
