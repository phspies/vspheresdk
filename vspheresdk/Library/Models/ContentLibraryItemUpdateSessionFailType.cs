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
    public class ContentLibraryItemUpdateSessionFailType 
    {
        /// <summary>
        /// Client side error message. This can be useful in providing some extra details about the client side failure. Note that
        /// the message won't be translated to the user's locale.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "client_error_message", Required = Required.AllowNull)]
        public string ClientErrorMessage { get; set; }
    }
}
