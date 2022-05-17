using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Hvc.Models.Enums;

namespace vspheresdk.Hvc.Models
{
    public class VcenterHvcManagementAdministratorsSetType 
    {
        /// <summary>
        /// Names the groups to be in the CloudAdminGroup Ex - xyz@abc.com where xyz is the group name and abc.com is the domain
        /// name
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "group_names", Required = Required.AllowNull)]
        public IList<string> GroupNames { get; set; }
    }
}
