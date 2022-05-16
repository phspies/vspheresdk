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
    public class VcenterVminstantCloneType 
    {
        /// <summary>
        /// Virtual machine to InstantClone from.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// VirtualMachine. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: VirtualMachine.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "source", Required = Required.AllowNull)]
        public string Source { get; set; }
        /// <summary>
        /// Name of the new virtual machine.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Virtual machine placement information.
        /// If this field is unset, the system will use the values from the source virtual machine. If specified, each field will be
        /// used for placement. If the fields result in disjoint placement the operation will fail. If the fields along with the
        /// placement values of the source virtual machine result in disjoint placement the operation will fail.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "placement")]
        public VcenterVminstantClonePlacementSpecType Placement { get; set; }
        /// <summary>
        /// Map of NICs to update.
        /// If unset, no NICs will be updated.
        /// When clients pass a value of this structure as a parameter, the key in the field map must be an identifier for the
        /// resource type: vcenter.vm.hardware.Ethernet. When operations return a value of this structure as a result, the key in
        /// the field map will be an identifier for the resource type: vcenter.vm.hardware.Ethernet.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "nics_to_update")]
        public Dictionary<string,VcenterVmHardwareEthernetUpdateType>? NicsToUpdate { get; set; }
        /// <summary>
        /// Indicates whether all NICs on the destination virtual machine should be disconnected from the newtwork
        /// If unset, connection status of all NICs on the destination virtual machine will be the same as on the source virtual
        /// machine.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "disconnect_all_nics")]
        public bool? DisconnectAllNics { get; set; }
        /// <summary>
        /// Map of parallel ports to Update.
        /// If unset, no parallel ports will be updated.
        /// When clients pass a value of this structure as a parameter, the key in the field map must be an identifier for the
        /// resource type: vcenter.vm.hardware.ParallelPort. When operations return a value of this structure as a result, the key
        /// in the field map will be an identifier for the resource type: vcenter.vm.hardware.ParallelPort.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "parallel_ports_to_update")]
        public Dictionary<string,VcenterVmHardwareParallelUpdateType>? ParallelPortsToUpdate { get; set; }
        /// <summary>
        /// Map of serial ports to Update.
        /// If unset, no serial ports will be updated.
        /// When clients pass a value of this structure as a parameter, the key in the field map must be an identifier for the
        /// resource type: vcenter.vm.hardware.SerialPort. When operations return a value of this structure as a result, the key in
        /// the field map will be an identifier for the resource type: vcenter.vm.hardware.SerialPort.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "serial_ports_to_update")]
        public Dictionary<string,VcenterVmHardwareSerialUpdateType>? SerialPortsToUpdate { get; set; }
        /// <summary>
        /// 128-bit SMBIOS UUID of a virtual machine represented as a hexadecimal string in "12345678-abcd-1234-cdef-123456789abc"
        /// format.
        /// If unset, will be generated.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "bios_uuid")]
        public string? BiosUuid { get; set; }
    }
}
