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
    public class VcenterVmTemplateLibraryItemsVersionsRollbackTypeA 
    {
        /// <summary>
        /// Specification to rollback the library item.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "spec")]
        public VcenterVmTemplateLibraryItemsVersionsRollbackSpecTypeA Spec { get; set; }
    }
}
