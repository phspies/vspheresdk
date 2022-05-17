using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Appliance.Models.Enums;

namespace vspheresdk.Appliance.Models
{
    public class ApplianceVmonServiceInfoType 
    {
        /// <summary>
        /// Service name key. Can be used to lookup resource bundle
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name_key", Required = Required.AllowNull)]
        public string NameKey { get; set; }
        /// <summary>
        /// Service description key. Can be used to lookup resource bundle
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description_key", Required = Required.AllowNull)]
        public string DescriptionKey { get; set; }
        /// <summary>
        /// Startup Type.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "startup_type", Required = Required.AllowNull)]
        public ApplianceVmonServiceStartupTypeEnum StartupType { get; set; }
        /// <summary>
        /// Running State.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "state", Required = Required.AllowNull)]
        public ApplianceVmonServiceStateEnumType State { get; set; }
        /// <summary>
        /// Health of service.
        /// This field is optional and it is only relevant when the value of Service.Info.state is STARTED.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "health")]
        public ApplianceVmonServiceHealthEnumType Health { get; set; }
        /// <summary>
        /// Localizable messages associated with the health of the service
        /// This field is optional and it is only relevant when the value of Service.Info.state is STARTED.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "health_messages")]
        public Dictionary<string,VapiStdLocalizableMessageTypeA> HealthMessages { get; set; }
    }
}
