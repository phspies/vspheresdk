using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Esx.Models.Enums;

namespace vspheresdk.Esx.Models
{
    public class EsxSettingsClustersSoftwareDraftsSoftwareComponentsUpdateSpecType 
    {
        /// <summary>
        /// List of components to be updated. If the component already exists in the draft, the version is updated, else it is
        /// added. If a component is provided without version, then its version will be chosen based on constraints in the system.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "components_to_set")]
        public object ComponentsToSet { get; set; }
        /// <summary>
        /// List of components to be removed.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "components_to_delete")]
        public IList<string> ComponentsToDelete { get; set; }
    }
}
