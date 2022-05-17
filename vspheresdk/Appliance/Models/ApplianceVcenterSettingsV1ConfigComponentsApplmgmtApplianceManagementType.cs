using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Appliance.Models.Enums;

namespace vspheresdk.Appliance.Models
{
    public class ApplianceVcenterSettingsV1ConfigComponentsApplmgmtApplianceManagementType 
    {
        /// <summary>
        /// Policy to update vCenter.
        /// Only set if the SoftwareUpdatePolicy is set inside vCenter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "software_update_policy")]
        public ApplianceVcenterSettingsV1ConfigComponentsApplmgmtSoftwareUpdatePolicyType SoftwareUpdatePolicy { get; set; }
        /// <summary>
        /// Backup schedule of vCenter.
        /// Only set if the Backup is schedule for vCenter
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "backup_schedules")]
        public Dictionary<string,ApplianceVcenterSettingsV1ConfigComponentsApplmgmtBackupScheduleType> BackupSchedules { get; set; }
        /// <summary>
        /// AccessSettings of vCenter. if access settings are set for vCenter
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "access_settings")]
        public ApplianceVcenterSettingsV1ConfigComponentsApplmgmtAccessSettingsType AccessSettings { get; set; }
        /// <summary>
        /// Date Time Configuration of vCenter.
        /// Only set if access settings are set for vCenter
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "datetime_config")]
        public ApplianceVcenterSettingsV1ConfigComponentsApplmgmtDatetimeConfigType DatetimeConfig { get; set; }
        /// <summary>
        /// The syslog service provides operations to manage forwarding of log messages to remote logging servers.
        /// Only set if log forwarding to remote server are set in vCenter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "syslog")]
        public Dictionary<string,ApplianceVcenterSettingsV1ConfigComponentsApplmgmtLogForwardingType> Syslog { get; set; }
        /// <summary>
        /// User Account Settings of vCenter. if user account settings are set for vCenter
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "user_account_settings")]
        public ApplianceVcenterSettingsV1ConfigComponentsApplmgmtUserAccountSettingsType UserAccountSettings { get; set; }
        /// <summary>
        /// The LocalAccounts service provides operations to manage local user account.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "smtp")]
        public ApplianceVcenterSettingsV1ConfigComponentsApplmgmtSmtpType Smtp { get; set; }
        /// <summary>
        /// Network configurations to be applied.
        /// Only set if the network configurations are set in vCenter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "network")]
        public ApplianceVcenterSettingsV1ConfigComponentsApplmgmtApplianceNetworkType Network { get; set; }
        /// <summary>
        /// CEIP (Customer Experience Improvement Program) enabled state.
        /// Only set if ceip are set in vcenter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ceip")]
        public ApplianceVcenterSettingsV1ConfigComponentsApplmgmtCeipType Ceip { get; set; }
    }
}
