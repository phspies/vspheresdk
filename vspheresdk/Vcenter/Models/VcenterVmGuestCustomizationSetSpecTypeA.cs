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
    public class VcenterVmGuestCustomizationSetSpecTypeA 
    {
        /// <summary>
        /// The name of the customization specification that has be retrieved from the virtual center inventory and applied for the
        /// virtual machine. Either one of Customization.SetSpec.name or Customization.SetSpec.spec or none of them should be
        /// specified.
        /// If unset and Customization.SetSpec.spec is also unset when executing Customization.set operationg, then any pending
        /// customization for the virtual machine will be cleared.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// The customization specification that has to be applied for the virtual machine. Either one of Customization.SetSpec.name
        /// or Customization.SetSpec.spec or none of them should be specified.
        /// If unset and Customization.SetSpec.name is also unset when executing Customization.set operationg, then any pending
        /// customization for the virtual machine will be cleared.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "spec")]
        public VcenterGuestCustomizationSpecTypeA Spec { get; set; }
    }
}
