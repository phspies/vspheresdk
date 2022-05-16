using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Stats.Models.Enums;

namespace vspheresdk.Stats.Models
{
    public class VstatsResourceAddressesListResultType 
    {
        /// <summary>
        /// List of Resource Addresses received. Warning: This attribute is available as Technology Preview. These are early access
        /// APIs provided to test, automate and provide feedback on the feature. Since this can change based on feedback, VMware
        /// does not guarantee backwards compatibility and recommends against using them in production environments. Some Technology
        /// Preview APIs might only be applicable to specific environments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "rsrc_addrs", Required = Required.AllowNull)]
        public Dictionary<string,VstatsResourceAddressesInfoType> RsrcAddrs { get; set; }
        /// <summary>
        /// Used to retrieve paged data for larger result sets. Token is generated by server. The value of this field should be
        /// supplied in a subsequent call to ResourceAddresses.list operation. Warning: This attribute is available as Technology
        /// Preview. These are early access APIs provided to test, automate and provide feedback on the feature. Since this can
        /// change based on feedback, VMware does not guarantee backwards compatibility and recommends against using them in
        /// production environments. Some Technology Preview APIs might only be applicable to specific environments.
        /// unset when there are no more pages of data to be retrieved.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "next")]
        public string? Next { get; set; }
    }
}