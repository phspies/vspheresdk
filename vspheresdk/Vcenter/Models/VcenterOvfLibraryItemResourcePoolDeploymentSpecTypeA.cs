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
    public class VcenterOvfLibraryItemResourcePoolDeploymentSpecTypeA 
    {
        /// <summary>
        /// Name assigned to the deployed target virtual machine or virtual appliance.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Annotation assigned to the deployed target virtual machine or virtual appliance.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "annotation")]
        public string? Annotation { get; set; }
        /// <summary>
        /// Whether to accept all End User License Agreements. See {@link OvfSummary#eulas}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "accept_all_EULA", Required = Required.AllowNull)]
        public bool AcceptAllEULA { get; set; }
        /// <summary>
        /// Specification of the target network to use for sections of type ovf:NetworkSection in the OVF descriptor. The key in the
        /// {@term map} is the section identifier of the ovf:NetworkSection section in the OVF descriptor and the value is the
        /// target network to be used for deployment.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "network_mappings")]
        public IList<object> NetworkMappings { get; set; }
        /// <summary>
        /// Specification of the target storage to use for sections of type vmw:StorageGroupSection in the OVF descriptor. The key
        /// in the {@term map} is the section identifier of the ovf:StorageGroupSection section in the OVF descriptor and the value
        /// is the target storage specification to be used for deployment. See {@link StorageGroupMapping}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "storage_mappings")]
        public IList<object> StorageMappings { get; set; }
        /// <summary>
        /// Default storage provisioning type to use for all sections of type vmw:StorageSection in the OVF descriptor.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "storage_provisioning")]
        public VcenterOvfDiskProvisioningTypeEnumA StorageProvisioning { get; set; }
        /// <summary>
        /// Default storage profile to use for all sections of type vmw:StorageSection in the OVF descriptor.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "storage_profile_id")]
        public string? StorageProfileId { get; set; }
        /// <summary>
        /// The locale to use for parsing the OVF descriptor.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "locale")]
        public string? Locale { get; set; }
        /// <summary>
        /// Flags to be use for deployment. The supported flag values can be obtained using {@link ImportFlag#list}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "flags")]
        public IList<string> Flags { get; set; }
        /// <summary>
        /// Additional OVF parameters that may be needed for the deployment. Additional OVF parameters may be required by the OVF
        /// descriptor of the OVF package in the library item. Examples of OVF parameters that can be specified through this {@term
        /// field} include, but are not limited to: <ul> <li>{@link DeploymentOptionParams}</li> <li>{@link ExtraConfigParams}</li>
        /// <li>{@link IpAllocationParams}</li> <li>{@link PropertyParams}</li> <li>{@link ScaleOutParams}</li> <li>{@link
        /// VcenterExtensionParams}</li> </ul>
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "additional_parameters")]
        public IList<object> AdditionalParameters { get; set; }
        /// <summary>
        /// Default datastore to use for all sections of type vmw:StorageSection in the OVF descriptor.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "default_datastore_id")]
        public string? DefaultDatastoreId { get; set; }
    }
}
