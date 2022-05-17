using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Esx.Models.Enums;

namespace vspheresdk.Esx.Models
{
    public class EsxHostsSoftwareConnectionSpecType 
    {
        /// <summary>
        /// Specifies what type of authentication ({@enum.values AuthenticationType}) is to be used when connecting with the host.
        /// USERNAME_PASSWORD is intended to be used when connecting to a host that is not currently part of the vCenter inventory.
        /// EXISTING is intented for hosts that are in vCenter inventory, in which case, HostServiceTicket will be used to connect
        /// to the host.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "auth_type", Required = Required.AllowNull)]
        public EsxHostsSoftwareConnectionSpecAuthenticationType AuthType { get; set; }
        /// <summary>
        /// Specifies the host details to be used during the {@link esx.hosts.Software#get} {@term operation}
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "host_credential")]
        public EsxHostsSoftwareHostCredentialsType HostCredential { get; set; }
        /// <summary>
        /// Specifies the host Managed Object ID to be used during the {@link esx.hosts.Software#get} {@term operation}
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        public string? Host { get; set; }
    }
}
