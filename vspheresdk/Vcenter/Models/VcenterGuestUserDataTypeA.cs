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
    public class VcenterGuestUserDataTypeA 
    {
        /// <summary>
        /// The computer name of the (Windows) virtual machine. A computer name may contain letters (A-Z), numbers(0-9) and hyphens
        /// (-) but no spaces or periods (.). The name may not consist entirely of digits. A computer name is restricted to 15
        /// characters in length. If the computer name is longer than 15 characters, it will be truncated to 15 characters. Check
        /// HostnameGenerator for various options.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "computer_name", Required = Required.AllowNull)]
        public VcenterGuestHostnameGeneratorTypeA ComputerName { get; set; }
        /// <summary>
        /// Full name of the end user. Note that this is not the username but full name specified in "Firstname Lastname" format.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "full_name", Required = Required.AllowNull)]
        public string FullName { get; set; }
        /// <summary>
        /// Name of the organization that owns the computer.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "organization", Required = Required.AllowNull)]
        public string Organization { get; set; }
        /// <summary>
        /// The product Key to use for activating Windows guest operating system.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "product_key", Required = Required.AllowNull)]
        public string ProductKey { get; set; }
    }
}
