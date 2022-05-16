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
    public class VcenterDeploymentUpgradeUpgradeSpecType 
    {
        /// <summary>
        /// Source appliance spec.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "source_appliance", Required = Required.AllowNull)]
        public VcenterDeploymentUpgradeSourceApplianceSpecType SourceAppliance { get; set; }
        /// <summary>
        /// Source location spec.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "source_location", Required = Required.AllowNull)]
        public VcenterDeploymentLocationSpecType SourceLocation { get; set; }
        /// <summary>
        /// Determines how vCenter history will be migrated during the upgrade process. vCenter history consists of:
        /// - Statistics
        /// - Events
        /// - Tasks
        /// By default only core data will be migrated. Use this spec to define which part of vCenter history data will be migrated
        /// and when.
        /// If unset, only core database content will be migrated.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "history")]
        public VcenterDeploymentHistoryMigrationSpecType History { get; set; }
        /// <summary>
        /// Information that are specific to this embedded vCenter Server.
        /// If unset, ceip_enabled for embedded vcenter server upgrade will default to enabled.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vcsa_embedded")]
        public VcenterDeploymentUpgradeVcsaEmbeddedSpecType VcsaEmbedded { get; set; }
        /// <summary>
        /// Information that are specific to this Platform Services Controller.
        /// If unset, ceip_enabled for psc upgrade will default to enabled.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "psc")]
        public VcenterDeploymentUpgradePscSpecType Psc { get; set; }
        /// <summary>
        /// Use the default option for any questions that may come up during appliance configuration.
        /// If unset, will default to false.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "auto_answer")]
        public bool? AutoAnswer { get; set; }
    }
}
