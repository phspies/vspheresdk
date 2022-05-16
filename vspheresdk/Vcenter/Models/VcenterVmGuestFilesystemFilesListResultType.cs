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
    public class VcenterVmGuestFilesystemFilesListResultType 
    {
        /// <summary>
        /// A list of Files.Summary structures containing information for all the matching files.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "files", Required = Required.AllowNull)]
        public Dictionary<string,VcenterVmGuestFilesystemFilesSummaryType> Files { get; set; }
        /// <summary>
        /// The total number of results from the Files.list. This is a hint to the user of the iterator regarding how many items are
        /// available to be retrieved. The total could change if the inventory of items are being changed.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "total", Required = Required.AllowNull)]
        public long Total { get; set; }
        /// <summary>
        /// Positional index into the logical item list of the first item returned in the list of results. The first item in the
        /// logical item list has an index of 0. This is a hint to the user of the iterator regarding the logical position in the
        /// iteration. For example, this can be used to display to the user which page of the iteration is being shown. The total
        /// could change if the inventory of items are being changed.
        /// If unset no items were returned.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "start_index")]
        public long? StartIndex { get; set; }
        /// <summary>
        /// Positional index into the logical item list of the last item returned in the list of results. The first item in the
        /// logical item list has an index of 0. This is a hint to the user of the iterator regarding the logical position in the
        /// iteration. For example, this can be used to display to the user which page of the iteration is being shown. The total
        /// could change if the inventory of items are being changed.
        /// If unset no items were returned.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "end_index")]
        public long? EndIndex { get; set; }
        /// <summary>
        /// The last status for the iterator that indicates whether any more results can be expected if the caller continues to make
        /// requests for more data using the iterator.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public VcenterVmGuestFilesystemFilesLastIterationStatusType Status { get; set; }
    }
}
