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
    public class VcenterDeploymentMigrateMigrateSpecType 
    {
        /// <summary>
        /// Information specific to the Windows vCenter Server.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "source_vc_windows", Required = Required.AllowNull)]
        public VcenterDeploymentMigrateSourceVcWindowsType SourceVcWindows { get; set; }
        /// <summary>
        /// Information specific to the Migration Assistant that is running on the Windows vCenter Server.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "existing_migration_assistant", Required = Required.AllowNull)]
        public VcenterDeploymentMigrateMigrationAssistantSpecType ExistingMigrationAssistant { get; set; }
        /// <summary>
        /// Determines how vCenter history will be migrated during the migration process. vCenter history consists of:
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
        /// Information specific to an embedded vCenter Server.
        /// Only required if the vCenter Server that is going to be migrated is an embedded vCenter Server.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vcsa_embedded")]
        public VcenterDeploymentMigrateVcsaEmbeddedSpecType VcsaEmbedded { get; set; }
        /// <summary>
        /// Information specific to a Platform Services Controller.
        /// Only required if the vCenter Server that is going to be migrated is a Platform Services Controller.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "psc")]
        public VcenterDeploymentMigratePscSpecType Psc { get; set; }
        /// <summary>
        /// Information specific to the Active Directory server to which the source windows vCenter Server is joined.
        /// If unset, existing appliance will not be joined to an Active Directory.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "active_directory")]
        public VcenterDeploymentMigrateActiveDirectorySpecType ActiveDirectory { get; set; }
        /// <summary>
        /// Use the default option for any questions that may come up during appliance configuration.
        /// If unset, will default to false.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "auto_answer")]
        public bool? AutoAnswer { get; set; }
    }
}
