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
    public class ApplianceVcenterSettingsV1ConfigComponentsApplmgmtUserAccountSettingsType 
    {
        /// <summary>
        /// The localAccountsPolicy service provides operations to manage local user accounts.
        /// Only set if Password Policy is set to manage local user accounts.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "local_accounts_policy")]
        public ApplianceVcenterSettingsV1ConfigComponentsApplmgmtLocalAccountsPolicyType LocalAccountsPolicy { get; set; }
        /// <summary>
        /// The LocalAccounts service provides operations to manage local user account.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "root_account_policy")]
        public ApplianceVcenterSettingsV1ConfigComponentsApplmgmtLocalAccountsType RootAccountPolicy { get; set; }
    }
}
