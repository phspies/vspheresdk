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
    public class VcenterIdentityProvidersOidcUpdateSpecTypeA 
    {
        /// <summary>
        /// Endpoint to retrieve the provider metadata
        /// If unset, leaves value unchanged.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "discovery_endpoint")]
        public string? DiscoveryEndpoint { get; set; }
        /// <summary>
        /// Client identifier to connect to the provider
        /// If unset, leaves value unchanged.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "client_id")]
        public string? ClientId { get; set; }
        /// <summary>
        /// The secret shared between the client and the provider
        /// If unset, leaves value unchanged.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "client_secret")]
        public string? ClientSecret { get; set; }
        /// <summary>
        /// The map used to transform an OAuth2 claim to a corresponding claim that vCenter Server understands. Currently only the
        /// key "perms" is supported. The key "perms" is used for mapping the "perms" claim of incoming JWT. The value is another
        /// map with an external group as the key and a vCenter Server group as value.
        /// If unset, leaves value unchanged.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "claim_map")]
        public IList<object> ClaimMap { get; set; }
    }
}
