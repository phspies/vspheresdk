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
    public class VcenterHostCreateType 
    {
        /// <summary>
        /// The IP address or DNS resolvable name of the host.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "hostname", Required = Required.AllowNull)]
        public string Hostname { get; set; }
        /// <summary>
        /// The port of the host.
        /// If unset, port 443 will be used.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public long? Port { get; set; }
        /// <summary>
        /// The administrator account on the host.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "user_name", Required = Required.AllowNull)]
        public string UserName { get; set; }
        /// <summary>
        /// The password for the administrator account on the host.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "password", Required = Required.AllowNull)]
        public string Password { get; set; }
        /// <summary>
        /// Host and cluster folder in which the new standalone host should be created.
        /// This field is currently required. In the future, if this field is unset, the system will attempt to choose a suitable
        /// folder for the host; if a folder cannot be chosen, the host creation operation will fail.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// Folder. When operations return a value of this structure as a result, the field will be an identifier for the resource
        /// type: Folder.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "folder")]
        public string? Folder { get; set; }
        /// <summary>
        /// Type of host's SSL certificate verification to be done.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "thumbprint_verification", Required = Required.AllowNull)]
        public VcenterHostCreateSpecThumbprintVerificationType ThumbprintVerification { get; set; }
        /// <summary>
        /// The thumbprint of the SSL certificate, which the host is expected to have. The thumbprint is always computed using the
        /// SHA1 hash and is the string representation of that hash in the format:
        /// xx:xx:xx:xx:xx:xx:xx:xx:xx:xx:xx:xx:xx:xx:xx:xx:xx:xx:xx:xx where, 'x' represents a hexadecimal digit.
        /// This field is optional and it is only relevant when the value of Host.CreateSpec.thumbprint-verification is THUMBPRINT.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "thumbprint")]
        public string? Thumbprint { get; set; }
        /// <summary>
        /// Whether host should be added to the vCenter Server even if it is being managed by another vCenter Server. The original
        /// vCenterServer loses connection to the host.
        /// If unset, forceAdd is default to false.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "force_add")]
        public bool? ForceAdd { get; set; }
    }
}
