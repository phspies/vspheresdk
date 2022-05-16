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
    public class VcenterVmHardwareDiskVmdkCreateSpecType 
    {
        /// <summary>
        /// Base name of the VMDK file. The name should not include the '.vmdk' file extension.
        /// If unset, a name (derived from the name of the virtual machine) will be chosen by the server.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Capacity of the virtual disk backing in bytes.
        /// If unset, defaults to a guest-specific capacity.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "capacity")]
        public long? Capacity { get; set; }
        /// <summary>
        /// The Disk.StoragePolicySpec structure contains information about the storage policy that is to be associated the with
        /// VMDK file.
        /// If unset the default storage policy of the target datastore (if applicable) is applied. Currently a default storage
        /// policy is only supported by object based datastores : VVol & vSAN. For non- object datastores, if unset then no storage
        /// policy would be associated with the VMDK file.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "storage_policy")]
        public VcenterVmHardwareDiskStoragePolicySpecType StoragePolicy { get; set; }
    }
}
