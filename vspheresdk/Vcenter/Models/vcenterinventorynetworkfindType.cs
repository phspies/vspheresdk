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
    public class VcenterInventoryNetworkFindType 
    {
        /// <summary>
        /// Identifiers of the vCenter Server networks for which information will be returned.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "networks", Required = Required.AllowNull)]
        public IList<string> Networks { get; set; }
    }
}
