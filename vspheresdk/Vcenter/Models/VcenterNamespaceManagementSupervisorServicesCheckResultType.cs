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
    public class VcenterNamespaceManagementSupervisorServicesCheckResultType 
    {
        /// <summary>
        /// Indicates if the provided content is valid.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public VcenterNamespaceManagementSupervisorServicesValidationStatusType Status { get; set; }
        /// <summary>
        /// The type of the provided content. When this SupervisorServices.CheckResult.content-type is CUSTOM_YAML, the
        /// SupervisorServices.CheckResult.status is always VALID because a custom format is not validated.
        /// If unset, the content type cannot be determined from the provided content.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "content_type")]
        public VcenterNamespaceManagementSupervisorServicesVersionsContentType ContentType { get; set; }
        /// <summary>
        /// The information about the Supervisor Service version retrieved from the provided content as a result of validation
        /// checks if the content is in the vSphere application format.
        /// If unset, the content is not in the vSphere application service format, or the SupervisorServices.CheckResult.status is
        /// INVALID.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vsphere_apps_check_result")]
        public VcenterNamespaceManagementSupervisorServicesVsphereAppsCheckResultType VsphereAppsCheckResult { get; set; }
        /// <summary>
        /// A list of messages indicating why the content was considered valid but contains information that should be reviewed
        /// closely.
        /// This field is optional and it is only relevant when the value of SupervisorServices.CheckResult.status is
        /// VALID_WITH_WARNINGS.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "warning_messages")]
        public Dictionary<string,VapiStdLocalizableMessageType> WarningMessages { get; set; }
        /// <summary>
        /// A list of messages indicating why the content was considered invalid.
        /// This field is optional and it is only relevant when the value of SupervisorServices.CheckResult.status is INVALID.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "error_messages")]
        public Dictionary<string,VapiStdLocalizableMessageType> ErrorMessages { get; set; }
    }
}
