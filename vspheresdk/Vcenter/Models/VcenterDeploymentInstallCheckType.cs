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
    public class VcenterDeploymentInstallCheckType 
    {
        /// <summary>
        /// Spec used to configure an embedded vCenter Server. This field describes how the embedded vCenter Server appliance should
        /// be configured.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vcsa_embedded", Required = Required.AllowNull)]
        public VcenterDeploymentInstallVcsaEmbeddedSpecType VcsaEmbedded { get; set; }
        /// <summary>
        /// Use the default option for any questions that may come up during appliance configuration.
        /// If unset, will default to false.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "auto_answer")]
        public bool? AutoAnswer { get; set; }
    }
}
