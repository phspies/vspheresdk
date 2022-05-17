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
    public class VcenterNamespaceManagementCnsfileConfigType 
    {
        /// <summary>
        /// 
        /// CNSFileConfig.vsan-clusters is a list of clusters to be used for provisioning file volumes.
        /// 
        /// As a prerequisite these clusters must have vSAN and vSAN file services enabled, and must be in the same vCenter as the
        /// Supervisor.
        /// 
        /// Currently this list must have a single entry which is the cluster identifier of the current cluster. This cluster must
        /// be a vSAN cluster and must have vSAN File Service enabled.
        /// 
        /// If a cluster in the list is not a vSAN cluster or does not have vSAN File Service enabled, an InvalidArgument error will
        /// be thrown from Clusters.enable, Clusters.update and Clusters.set APIs.
        /// 
        /// An empty list may be specified to disable file volume support on the Supervisor.
        /// 
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// ClusterComputeResource. When operations return a value of this structure as a result, the field will contain identifiers
        /// for the resource type: ClusterComputeResource.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vsan_clusters", Required = Required.AllowNull)]
        public IList<string> VsanClusters { get; set; }
    }
}
