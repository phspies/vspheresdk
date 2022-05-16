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
    public class VcenterVmGuestFilesystemFilesListType 
    {
        /// <summary>
        /// The guest authentication data.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "credentials", Required = Required.AllowNull)]
        public VcenterVmGuestCredentialsType Credentials { get; set; }
        /// <summary>
        /// The complete path to the directory or file to query.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "path", Required = Required.AllowNull)]
        public string Path { get; set; }
        /// <summary>
        /// The specification of a page of results to be retrieved.
        /// If unset, the first page will be retrieved.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "iteration")]
        public VcenterVmGuestFilesystemFilesIterationSpecType Iteration { get; set; }
        /// <summary>
        /// Specification to match files for which information should be returned.
        /// If unset, the behavior is the equivalent to a Files.FilterSpec with all fields unset which means all filenames match the
        /// filter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "filter")]
        public VcenterVmGuestFilesystemFilesFilterSpecType Filter { get; set; }
    }
}
