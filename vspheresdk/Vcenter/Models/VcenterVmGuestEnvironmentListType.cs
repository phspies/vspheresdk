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
    public class VcenterVmGuestEnvironmentListType 
    {
        /// <summary>
        /// The guest authentication data. See Credentials.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "credentials", Required = Required.AllowNull)]
        public VcenterVmGuestCredentialsType Credentials { get; set; }
        /// <summary>
        /// The names of the variables to be read. If the set is empty, then all the environment variables are returned.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "names", Required = Required.AllowNull)]
        public IList<string> Names { get; set; }
    }
}
