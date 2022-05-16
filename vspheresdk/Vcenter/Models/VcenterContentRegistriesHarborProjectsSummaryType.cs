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
    public class VcenterContentRegistriesHarborProjectsSummaryType 
    {
        /// <summary>
        /// Identifier of the harbor project.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "project", Required = Required.AllowNull)]
        public string Project { get; set; }
        /// <summary>
        /// Name of the Harbor project. Should be between 1-63 characters long alphanumeric string and may contain the following
        /// characters: a-z,0-9, and '-'. Must be starting with characters or numbers, with the '-' character allowed anywhere
        /// except the first or last character.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Access type of a Harbor project.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "scope", Required = Required.AllowNull)]
        public VcenterContentRegistriesHarborProjectsScopeType Scope { get; set; }
    }
}
