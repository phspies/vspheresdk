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
    public class VcenterNamespacesInstancesVMServiceSpecTypeA 
    {
        /// <summary>
        /// Set of content libraries for use by the VM Service. The content libraries specified should exist in vSphere inventory.
        /// This field is optional because it was added in a newer version than its parent node.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// content.Library. When operations return a value of this structure as a result, the field will contain identifiers for
        /// the resource type: content.Library.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "content_libraries")]
        public IList<string> ContentLibraries { get; set; }
        /// <summary>
        /// Set of VirtualMachineClasses for use by the VM Service. The class names specified here should exist in vSphere
        /// inventory. If this field is empty in an updated specification, all VirtualMachineClasses that are currently associated
        /// with the namespace will be disassociated from it.
        /// NOTE: Any change in virtual machine classes associated with the namespace will not impact existing VMs.
        /// 
        /// This field is optional because it was added in a newer version than its parent node.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// vcenter.namespace_management.VirtualMachineClass. When operations return a value of this structure as a result, the
        /// field will contain identifiers for the resource type: vcenter.namespace_management.VirtualMachineClass.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vm_classes")]
        public IList<string> VmClasses { get; set; }
    }
}
