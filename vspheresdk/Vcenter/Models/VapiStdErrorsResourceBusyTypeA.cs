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
    public class VapiStdErrorsResourceBusyTypeA 
    {
        /// <summary>
        /// Stack of one or more localizable messages for human {@term error} consumers. <p> The message at the top of the stack
        /// (first in the list) describes the {@term error} from the perspective of the {@term operation} the client invoked. Each
        /// subsequent message in the stack describes the "cause" of the prior message.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "messages", Required = Required.AllowNull)]
        public Dictionary<string,VapiStdLocalizableMessageTypeA> Messages { get; set; }
        /// <summary>
        /// Data to facilitate clients responding to the {@term operation} reporting a standard {@term error} to indicating that it
        /// was unable to complete successfully. <p> {@term Operations} may provide data that clients can use when responding to
        /// {@term errors}.  Since the data that clients need may be specific to the context of the {@term operation} reporting the
        /// {@term error}, different {@term operations} that report the same {@term error} may provide different data in the {@term
        /// error}.  The documentation for each each {@term operation} will describe what, if any, data it provides for each {@term
        /// error} it reports. The {@link ArgumentLocations}, {@link FileLocations}, and {@link TransientIndication} {@term
        /// structures} are intended as possible values for this {@term field}.  {@link vapi.std.DynamicID} may also be useful as a
        /// value for this {@term field} (although that is not its primary purpose).  Some {@term services} may provide their own
        /// specific {@term structures} for use as the value of this {@term field} when reporting {@term errors} from their {@term
        /// operations}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public object Data { get; set; }
        /// <summary>
        /// Discriminator field to help API consumers identify the structure type.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "error_type")]
        public VapiStdErrorsErrorTypeA ErrorType { get; set; }
    }
}
