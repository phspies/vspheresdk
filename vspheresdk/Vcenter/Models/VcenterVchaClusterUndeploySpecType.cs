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
    public class VcenterVchaClusterUndeploySpecType 
    {
        /// <summary>
        /// Contains the active node's management vCenter server credentials.
        /// If unset, then the active vCenter Server instance is assumed to be either self-managed or else in enhanced linked mode
        /// and managed by a linked vCenter Server instance.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vc_spec")]
        public VcenterVchaCredentialsSpecType VcSpec { get; set; }
        /// <summary>
        /// Flag controlling in what circumstances the virtual machines will be deleted. For this flag to take effect, the VCHA
        /// cluster should have been successfully configured using automatic deployment.
        /// -  If true, the Cluster.UndeploySpec.vms field will be ignored, the VCHA cluster specific information is removed, and
        /// the passive and witness virtual machines will be deleted.
        /// -  If false, the Cluster.UndeploySpec.vms field contains the information identifying the passive and witness virtual
        /// machines.
        /// 
        /// =  If the Cluster.UndeploySpec.vms field is set, then it will be validated prior to deleting the passive and witness
        /// virtual machines and VCHA cluster specific information is removed.
        /// =  If the Cluster.UndeploySpec.vms field is unset, then the passive and witness virtual machines will not be deleted.
        /// The customer should delete them in order to cleanup completely. VCHA cluster specific information is removed.
        /// 
        /// If unset, the Cluster.UndeploySpec.vms field contains the information identifying the passive and witness virtual
        /// machines.
        /// -  If the Cluster.UndeploySpec.vms field is set, then it will be validated prior to deleting the passive and witness
        /// virtual machines. VCHA cluster specific information is removed.
        /// -  If the Cluster.UndeploySpec.vms field is unset, then the passive and witness virtual machines will not be deleted.
        /// The customer should delete them in order to cleanup completely. VCHA cluster specific information is removed.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "force_delete")]
        public bool? ForceDelete { get; set; }
        /// <summary>
        /// Contains virtual machine information for the passive and witness virtual machines. For this flag to take effect, the
        /// VCHA cluster should have been successfully configured using automatic deployment.
        /// If set, the Cluster.UndeploySpec.force-delete field controls whether this information is validated.
        /// 
        /// -  If the Cluster.UndeploySpec.force-delete field is true, then this information is ignored, VCHA cluster specific
        /// information is removed and the passive and witness virtual machines will be deleted.
        /// -  If the Cluster.UndeploySpec.force-delete field is unset or false, then this information is validated prior to
        /// deleting the passive and witness virtual machines. VCHA cluster specific information is removed.
        /// 
        /// If unset, the Cluster.UndeploySpec.force-delete field controls the deletion of the passive and witness virtual machines.
        /// -  If the Cluster.UndeploySpec.force-delete field is true, then the passive and witness virtual machines will be
        /// deleted. VCHA cluster specific information is removed.
        /// -  If the Cluster.UndeploySpec.force-delete field is unset or false, then the passive and witness virtual machines will
        /// not be deleted. The customer should delete them in order to cleanup completely. VCHA cluster specific information is
        /// removed.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vms")]
        public VcenterVchaClusterVmInfoType Vms { get; set; }
    }
}
