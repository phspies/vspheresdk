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
    public class VcenterGuestCloudinitConfigurationType 
    {
        /// <summary>
        /// Metadata includes the network, instance id and hostname that cloud-init processes to configure the virtual machine. It
        /// is in json or yaml format. The max size of the metadata is 524288 bytes. See
        /// https://cloudinit.readthedocs.io/en/latest/topics/datasources/ovf.html about supported meta data formats.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "metadata", Required = Required.AllowNull)]
        public string Metadata { get; set; }
        /// <summary>
        /// Userdata is the user customized content that cloud-init processes to configure the virtual machine. See
        /// https://cloudinit.readthedocs.io/en/latest/topics/format.html about user data formats. See
        /// https://cloudinit.readthedocs.io/en/latest/topics/modules.html# about user data modules. The max size of the userdata is
        /// 524288 bytes.
        /// If unset, no cloud-init user data will be used as part of the cloud-init configuration.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "userdata")]
        public string? Userdata { get; set; }
    }
}
