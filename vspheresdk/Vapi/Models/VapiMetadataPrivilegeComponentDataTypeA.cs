using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Vapi.Models.Enums;

namespace vspheresdk.Vapi.Models
{
    public class VapiMetadataPrivilegeComponentDataTypeA 
    {
        /// <summary>
        /// Privilege information of the component. This includes information about all the {@term packages} in the component.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "info", Required = Required.AllowNull)]
        public VapiMetadataPrivilegeComponentInfoTypeA Info { get; set; }
        /// <summary>
        /// Fingerprint of the metadata of the component. <p> Privilege information could change when there is an infrastructure
        /// update. Since the data present in {@link ComponentData#info} could be quite large, {@name #fingerprint} provides a
        /// convenient way to check if the data for a particular component is updated. <p> You should store the fingerprint
        /// associated with a component. After an update, by invoking the {@link vapi.metadata.privilege.Component#fingerprint}
        /// {@term operation}, you can retrieve the new fingerprint for the component. If the new fingerprint and the previously
        /// stored fingerprint do not match, clients can then use the {@link vapi.metadata.privilege.Component#get} to retrieve the
        /// new privilege information for the component.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "fingerprint", Required = Required.AllowNull)]
        public string Fingerprint { get; set; }
    }
}
