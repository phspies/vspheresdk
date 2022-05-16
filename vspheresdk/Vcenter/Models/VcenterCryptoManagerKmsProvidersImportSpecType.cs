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
    public class VcenterCryptoManagerKmsProvidersImportSpecType 
    {
        /// <summary>
        /// Configuration to import.
        /// Currently this is required. Other import methods may be supported in the future.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "config")]
        public string? Config { get; set; }
        /// <summary>
        /// Password to decrypt the configuration to import.
        /// If unset or empty, configuration to import must be unencrypted.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
        /// <summary>
        /// Constraints to impose on the imported provider
        /// If unset, the imported provider constraints will match the exported provider constraints.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "constraints")]
        public VcenterCryptoManagerKmsProvidersConstraintsSpecType Constraints { get; set; }
        /// <summary>
        /// Whether to perform a trial import without actuallly creating a provider.
        /// If unset, a new provider will be created.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "dry_run")]
        public bool? DryRun { get; set; }
    }
}
