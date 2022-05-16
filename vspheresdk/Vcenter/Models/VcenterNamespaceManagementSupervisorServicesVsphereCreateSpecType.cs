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
    public class VcenterNamespaceManagementSupervisorServicesVsphereCreateSpecType 
    {
        /// <summary>
        /// Supervisor service version specification that provides the service definitions for one Supervisor Service version.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "version_spec", Required = Required.AllowNull)]
        public VcenterNamespaceManagementSupervisorServicesVersionsVsphereCreateSpecType VersionSpec { get; set; }
    }
}
