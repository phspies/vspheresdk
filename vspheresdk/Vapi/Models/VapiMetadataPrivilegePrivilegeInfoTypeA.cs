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
    public class VapiMetadataPrivilegePrivilegeInfoTypeA 
    {
        /// <summary>
        /// The {@name #propertyPath} points to an entity that is used in the operation element. An entity can either be present in
        /// one of the parameter elements or if a parameter is a structure element, it could also be present in one of the field
        /// elements. <p> If the privilege is assigned to an entity used in the parameter, {@name #propertyPath} will just contain
        /// the name of the parameter field. If the privilege is assigned to an entity in one of the field elements of a parameter
        /// element that is a structure element, then {@name #propertyPath} will contain a path to the field element starting from
        /// the parameter name.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "property_path", Required = Required.AllowNull)]
        public string PropertyPath { get; set; }
        /// <summary>
        /// List of privileges assigned to the entity that is being referred by {@link #propertyPath}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "privileges", Required = Required.AllowNull)]
        public IList<string> Privileges { get; set; }
    }
}
