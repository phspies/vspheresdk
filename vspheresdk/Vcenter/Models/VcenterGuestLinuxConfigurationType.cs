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
    public class VcenterGuestLinuxConfigurationType 
    {
        /// <summary>
        /// The network host name of the Linux virtual machine.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "hostname", Required = Required.AllowNull)]
        public VcenterGuestHostnameGeneratorType Hostname { get; set; }
        /// <summary>
        /// The fully qualified domain name.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "domain", Required = Required.AllowNull)]
        public string Domain { get; set; }
        /// <summary>
        /// The case-sensitive time zone, such as Europe/Sofia. Valid time zone values are based on the tz (time zone) database used
        /// by Linux. The values are strings (string) in the form "Area/Location," in which Area is a continent or ocean name, and
        /// Location is the city, island, or other regional designation.
        /// See the https://kb.vmware.com/kb/2145518 for a list of supported time zones for different versions in Linux.
        /// 
        /// If unset, time zone is not modified inside guest operating system.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "time_zone")]
        public string? TimeZone { get; set; }
        /// <summary>
        /// The script to run before and after Linux guest customization.
        /// The max size of the script is 1500 bytes. As long as the script (shell, perl, python...) has the right "#!" in the
        /// header, it is supported. The caller should not assume any environment variables when the script is run.
        /// The script is invoked by the customization engine using the command line: 1) with argument "precustomization" before
        /// customization, 2) with argument "postcustomization" after customization. The script should parse this argument and
        /// implement pre-customization or post-customization task code details in the corresponding block.
        /// 
        /// A Linux shell script example:
        /// 
        /// #!/bin/sh
        /// if [ x$1 == x"precustomization" ]; then
        /// echo "Do Precustomization tasks"
        /// #code for pre-customization actions...
        /// elif [ x$1 == x"postcustomization" ]; then
        /// echo "Do Postcustomization tasks"
        /// #code for post-customization actions...
        /// fi
        /// 
        /// 
        /// If unset, no script will be executed.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "script_text")]
        public string? ScriptText { get; set; }
    }
}
