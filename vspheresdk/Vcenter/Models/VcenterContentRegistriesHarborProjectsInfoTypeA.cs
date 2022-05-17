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
    public class VcenterContentRegistriesHarborProjectsInfoTypeA 
    {
        /// <summary>
        /// Name of the Harbor project. Should be between 1-63 characters long alphanumeric string and may contain the following
        /// characters: a-z,0-9, and '-'. Must be starting with characters or numbers, with the '-' character allowed anywhere
        /// except the first or last character.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// The status of the Harbor project.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "config_status", Required = Required.AllowNull)]
        public VcenterContentRegistriesHarborProjectsConfigStatusEnumTypeA ConfigStatus { get; set; }
        /// <summary>
        /// The access type of a Harbor project.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "scope", Required = Required.AllowNull)]
        public VcenterContentRegistriesHarborProjectsScopeEnumTypeA Scope { get; set; }
        /// <summary>
        /// The date and time when the harbor project creation API was triggered and project identifier generated.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "creation_time", Required = Required.AllowNull)]
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// The date and time when the harbor project purge API was triggered. In case no purge was triggered, {@name #updateTime}
        /// is same as {@name #creationTime}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "update_time")]
        public DateTime? UpdateTime { get; set; }
        /// <summary>
        /// URL to access the harbor project through docker client.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "access_url")]
        public string? AccessUrl { get; set; }
        /// <summary>
        /// Details about the ERROR project status.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public VapiStdLocalizableMessageTypeA Message { get; set; }
    }
}
