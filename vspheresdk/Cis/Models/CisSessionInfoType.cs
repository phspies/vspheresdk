using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Cis.Models.Enums;

namespace vspheresdk.Cis.Models
{
    public class CisSessionInfoType 
    {
        /// <summary>
        /// Fully qualified name of the end user that created the session, for example Administrator@vsphere.local. A typical use
        /// case for this information is in Graphical User Interfaces (GUI) or logging systems to visualize the identity of the
        /// current user.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "user", Required = Required.AllowNull)]
        public string User { get; set; }
        /// <summary>
        /// Time when the session was created.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "created_time", Required = Required.AllowNull)]
        public DateTime CreatedTime { get; set; }
        /// <summary>
        /// Last time this session was used by passing the session token for invoking an API.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "last_accessed_time", Required = Required.AllowNull)]
        public DateTime LastAccessedTime { get; set; }
    }
}
