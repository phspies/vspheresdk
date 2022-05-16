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
    public class VcenterVmGuestFilesystemTransfersCreateType 
    {
        /// <summary>
        /// The guest authentication credentials.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "credentials", Required = Required.AllowNull)]
        public VcenterVmGuestCredentialsType Credentials { get; set; }
        /// <summary>
        /// A specification of the type of file transfer and any applicable attibutes.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "spec", Required = Required.AllowNull)]
        public VcenterVmGuestFilesystemTransfersCreateSpecType Spec { get; set; }
    }
}
