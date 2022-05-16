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
    public class VcenterVmToolsUpdateSpecTypeA 
    {
        /// <summary>
        /// Tools upgrade policy setting for the virtual machine. Tools.UpgradePolicy
        /// If unset the upgrade policy will not be modified.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "upgrade_policy")]
        public VcenterVmToolsUpgradePolicyTypeA UpgradePolicy { get; set; }
    }
}
