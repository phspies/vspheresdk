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
    public class VcenterHvcManagementAdministratorsAddType 
    {
        /// <summary>
        /// Name of the new group to be added. Ex - xyz@abc.com where xyz is the group name and abc.com is the domain name
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "group_name", Required = Required.AllowNull)]
        public string GroupName { get; set; }
    }
}
