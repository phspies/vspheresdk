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
    public class VcenterOvfParseIssueTypeA 
    {
        /// <summary>
        /// The category of the parse issue.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "category", Required = Required.AllowNull)]
        public VcenterOvfParseIssueCategoryEnumTypeA Category { get; set; }
        /// <summary>
        /// The name of the file in which the parse issue was found.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "file", Required = Required.AllowNull)]
        public string File { get; set; }
        /// <summary>
        /// The line number of the line in the file (see {@link #file}) where the parse issue was found (or -1 if not applicable).
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "line_number", Required = Required.AllowNull)]
        public long LineNumber { get; set; }
        /// <summary>
        /// The position in the line (see {@link #lineNumber}) (or -1 if not applicable).
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "column_number", Required = Required.AllowNull)]
        public long ColumnNumber { get; set; }
        /// <summary>
        /// A localizable message describing the parse issue.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "message", Required = Required.AllowNull)]
        public VapiStdLocalizableMessageTypeA Message { get; set; }
    }
}
