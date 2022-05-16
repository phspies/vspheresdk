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
    public class VcenterInventoryDatastoreFindType 
    {
        /// <summary>
        /// Identifiers of the datastores for which information will be returned.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "datastores", Required = Required.AllowNull)]
        public IList<string> Datastores { get; set; }
    }
}
