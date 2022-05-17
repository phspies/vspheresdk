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
    public class EsxSettingsHardwareSupportManagersPackagesVersionsFilterSpecType 
    {
        /// <summary>
        /// vSphere release version for the component information in the Hardware Support Package (HSP). Only Hardware Support
        /// Packages (HSPs) compatible with the vSphere release version specified in 'baseImageVersion' will be returned. The
        /// 'baseImageVersion' parameter should be a full numeric base image version string (e.g. "7.1.0-2.3.436234"). Future
        /// implementations may support version specification by prefix (e.g. "7.1" to specify all updates and builds of 7.1) or
        /// other forms of specification (e.g. ">=7.0"). Hardware Support Pacakges (HSPs) may be advertised as supporting truncated
        /// version strings to indicate the remainder is wildcarded. Matching is on the specified substring only, so a bundle
        /// supporting "7.1.0-2" would match a 'release' parameter of "7.1.0-2.3.436234" as well as "7.1.0-2.1.4133564" and
        /// "7.1.0-2.0.355667" but not "7.1.0-3.0.63445" or any base image version starting with "7.2". Note that we require
        /// compatible base image versions be specified at least down to the update version (i.e. "7.0" is insufficiently
        /// constrained)
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "base_image_version")]
        public string? BaseImageVersion { get; set; }
    }
}
