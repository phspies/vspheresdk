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
    public class ContentLibraryItemUpdatesessionFileValidationResultTypeA 
    {
        /// <summary>
        /// Whether the validation was succesful or not. In case of errors, the {@link #missingFiles} and {@link #invalidFiles} will
        /// contain at least one entry.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "has_errors", Required = Required.AllowNull)]
        public bool HasErrors { get; set; }
        /// <summary>
        /// A {@term set} containing the names of the files that are required but the client hasn't added.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "missing_files", Required = Required.AllowNull)]
        public IList<string> MissingFiles { get; set; }
        /// <summary>
        /// A {@term list} containing the files that have been identified as invalid and details about the error.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "invalid_files", Required = Required.AllowNull)]
        public Dictionary<string,ContentLibraryItemUpdatesessionFileValidationErrorTypeA> InvalidFiles { get; set; }
    }
}
