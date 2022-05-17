using System;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Serializers.NewtonsoftJson;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using vspheresdk.Esx.Modules;
using vspheresdk;
using System.Threading;

namespace vspheresdk
{
    public class EsxSubModule
    {
        JsonSerializerSettings defaultSerializationSettings;
        RestClient restClient;
        private CancellationToken cancellationToken;
        private int timeout;
        private int retry;
        public EsxSubModule(RestClient RestClient, CancellationToken _cancellationToken = default(CancellationToken), int Port = 443, int _timeout = 5, int _retry = 2)
        {
            cancellationToken = _cancellationToken;
            timeout = _timeout;
            retry = _retry;
            restClient = RestClient;
        }
        public HclCompatibilityDataModule HclCompatibilityDataModule => new HclCompatibilityDataModule(restClient, cancellationToken, timeout, retry);
        public HclHostsCompatibilityReleasesModule HclHostsCompatibilityReleasesModule => new HclHostsCompatibilityReleasesModule(restClient, cancellationToken, timeout, retry);
        public HclHostsCompatibilityReportModule HclHostsCompatibilityReportModule => new HclHostsCompatibilityReportModule(restClient, cancellationToken, timeout, retry);
        public HclReportsModule HclReportsModule => new HclReportsModule(restClient, cancellationToken, timeout, retry);
        public HostsSoftwareInstalledComponentsModule HostsSoftwareInstalledComponentsModule => new HostsSoftwareInstalledComponentsModule(restClient, cancellationToken, timeout, retry);
        public SettingsClustersDepotOverridesModule SettingsClustersDepotOverridesModule => new SettingsClustersDepotOverridesModule(restClient, cancellationToken, timeout, retry);
        public SettingsClustersEnablementSoftwareModule SettingsClustersEnablementSoftwareModule => new SettingsClustersEnablementSoftwareModule(restClient, cancellationToken, timeout, retry);
        public SettingsClustersPoliciesApplyModule SettingsClustersPoliciesApplyModule => new SettingsClustersPoliciesApplyModule(restClient, cancellationToken, timeout, retry);
        public SettingsClustersPoliciesApplyEffectiveModule SettingsClustersPoliciesApplyEffectiveModule => new SettingsClustersPoliciesApplyEffectiveModule(restClient, cancellationToken, timeout, retry);
        public SettingsClustersSoftwareModule SettingsClustersSoftwareModule => new SettingsClustersSoftwareModule(restClient, cancellationToken, timeout, retry);
        public SettingsClustersSoftwareAddOnModule SettingsClustersSoftwareAddOnModule => new SettingsClustersSoftwareAddOnModule(restClient, cancellationToken, timeout, retry);
        public SettingsClustersSoftwareBaseImageModule SettingsClustersSoftwareBaseImageModule => new SettingsClustersSoftwareBaseImageModule(restClient, cancellationToken, timeout, retry);
        public SettingsClustersSoftwareCommitsModule SettingsClustersSoftwareCommitsModule => new SettingsClustersSoftwareCommitsModule(restClient, cancellationToken, timeout, retry);
        public SettingsClustersSoftwareComplianceModule SettingsClustersSoftwareComplianceModule => new SettingsClustersSoftwareComplianceModule(restClient, cancellationToken, timeout, retry);
        public SettingsClustersSoftwareComponentsModule SettingsClustersSoftwareComponentsModule => new SettingsClustersSoftwareComponentsModule(restClient, cancellationToken, timeout, retry);
        public SettingsClustersSoftwareDraftsModule SettingsClustersSoftwareDraftsModule => new SettingsClustersSoftwareDraftsModule(restClient, cancellationToken, timeout, retry);
        public SettingsClustersSoftwareDraftsSoftwareAddOnModule SettingsClustersSoftwareDraftsSoftwareAddOnModule => new SettingsClustersSoftwareDraftsSoftwareAddOnModule(restClient, cancellationToken, timeout, retry);
        public SettingsClustersSoftwareDraftsSoftwareBaseImageModule SettingsClustersSoftwareDraftsSoftwareBaseImageModule => new SettingsClustersSoftwareDraftsSoftwareBaseImageModule(restClient, cancellationToken, timeout, retry);
        public SettingsClustersSoftwareDraftsSoftwareComponentsModule SettingsClustersSoftwareDraftsSoftwareComponentsModule => new SettingsClustersSoftwareDraftsSoftwareComponentsModule(restClient, cancellationToken, timeout, retry);
        public SettingsClustersSoftwareDraftsSoftwareEffectiveComponentsModule SettingsClustersSoftwareDraftsSoftwareEffectiveComponentsModule => new SettingsClustersSoftwareDraftsSoftwareEffectiveComponentsModule(restClient, cancellationToken, timeout, retry);
        public SettingsClustersSoftwareDraftsSoftwareHardwareSupportModule SettingsClustersSoftwareDraftsSoftwareHardwareSupportModule => new SettingsClustersSoftwareDraftsSoftwareHardwareSupportModule(restClient, cancellationToken, timeout, retry);
        public SettingsClustersSoftwareEffectiveComponentsModule SettingsClustersSoftwareEffectiveComponentsModule => new SettingsClustersSoftwareEffectiveComponentsModule(restClient, cancellationToken, timeout, retry);
        public SettingsClustersSoftwareHardwareSupportModule SettingsClustersSoftwareHardwareSupportModule => new SettingsClustersSoftwareHardwareSupportModule(restClient, cancellationToken, timeout, retry);
        public SettingsClustersSoftwareRecommendationsModule SettingsClustersSoftwareRecommendationsModule => new SettingsClustersSoftwareRecommendationsModule(restClient, cancellationToken, timeout, retry);
        public SettingsClustersSoftwareReportsApplyImpactModule SettingsClustersSoftwareReportsApplyImpactModule => new SettingsClustersSoftwareReportsApplyImpactModule(restClient, cancellationToken, timeout, retry);
        public SettingsClustersSoftwareReportsHardwareCompatibilityModule SettingsClustersSoftwareReportsHardwareCompatibilityModule => new SettingsClustersSoftwareReportsHardwareCompatibilityModule(restClient, cancellationToken, timeout, retry);
        public SettingsClustersSoftwareReportsHardwareCompatibilityDetailsModule SettingsClustersSoftwareReportsHardwareCompatibilityDetailsModule => new SettingsClustersSoftwareReportsHardwareCompatibilityDetailsModule(restClient, cancellationToken, timeout, retry);
        public SettingsClustersSoftwareReportsHardwareCompatibilityStorageDeviceOverridesComplianceStatusModule SettingsClustersSoftwareReportsHardwareCompatibilityStorageDeviceOverridesComplianceStatusModule => new SettingsClustersSoftwareReportsHardwareCompatibilityStorageDeviceOverridesComplianceStatusModule(restClient, cancellationToken, timeout, retry);
        public SettingsClustersSoftwareReportsHardwareCompatibilityStorageDeviceOverridesVcgEntriesModule SettingsClustersSoftwareReportsHardwareCompatibilityStorageDeviceOverridesVcgEntriesModule => new SettingsClustersSoftwareReportsHardwareCompatibilityStorageDeviceOverridesVcgEntriesModule(restClient, cancellationToken, timeout, retry);
        public SettingsClustersSoftwareReportsLastApplyResultModule SettingsClustersSoftwareReportsLastApplyResultModule => new SettingsClustersSoftwareReportsLastApplyResultModule(restClient, cancellationToken, timeout, retry);
        public SettingsClustersSoftwareReportsLastCheckResultModule SettingsClustersSoftwareReportsLastCheckResultModule => new SettingsClustersSoftwareReportsLastCheckResultModule(restClient, cancellationToken, timeout, retry);
        public SettingsClustersSoftwareSolutionsModule SettingsClustersSoftwareSolutionsModule => new SettingsClustersSoftwareSolutionsModule(restClient, cancellationToken, timeout, retry);
        public SettingsDefaultsClustersPoliciesApplyModule SettingsDefaultsClustersPoliciesApplyModule => new SettingsDefaultsClustersPoliciesApplyModule(restClient, cancellationToken, timeout, retry);
        public SettingsDefaultsClustersPoliciesApplyEffectiveModule SettingsDefaultsClustersPoliciesApplyEffectiveModule => new SettingsDefaultsClustersPoliciesApplyEffectiveModule(restClient, cancellationToken, timeout, retry);
        public SettingsDepotContentAddOnsModule SettingsDepotContentAddOnsModule => new SettingsDepotContentAddOnsModule(restClient, cancellationToken, timeout, retry);
        public SettingsDepotContentAddOnsVersionsModule SettingsDepotContentAddOnsVersionsModule => new SettingsDepotContentAddOnsVersionsModule(restClient, cancellationToken, timeout, retry);
        public SettingsDepotContentBaseImagesModule SettingsDepotContentBaseImagesModule => new SettingsDepotContentBaseImagesModule(restClient, cancellationToken, timeout, retry);
        public SettingsDepotContentBaseImagesVersionsModule SettingsDepotContentBaseImagesVersionsModule => new SettingsDepotContentBaseImagesVersionsModule(restClient, cancellationToken, timeout, retry);
        public SettingsDepotContentComponentsModule SettingsDepotContentComponentsModule => new SettingsDepotContentComponentsModule(restClient, cancellationToken, timeout, retry);
        public SettingsDepotContentComponentsVersionsModule SettingsDepotContentComponentsVersionsModule => new SettingsDepotContentComponentsVersionsModule(restClient, cancellationToken, timeout, retry);
        public SettingsDepotsOfflineModule SettingsDepotsOfflineModule => new SettingsDepotsOfflineModule(restClient, cancellationToken, timeout, retry);
        public SettingsDepotsOfflineContentModule SettingsDepotsOfflineContentModule => new SettingsDepotsOfflineContentModule(restClient, cancellationToken, timeout, retry);
        public SettingsDepotsOnlineModule SettingsDepotsOnlineModule => new SettingsDepotsOnlineModule(restClient, cancellationToken, timeout, retry);
        public SettingsDepotsOnlineContentModule SettingsDepotsOnlineContentModule => new SettingsDepotsOnlineContentModule(restClient, cancellationToken, timeout, retry);
        public SettingsDepotsSyncScheduleModule SettingsDepotsSyncScheduleModule => new SettingsDepotsSyncScheduleModule(restClient, cancellationToken, timeout, retry);
        public SettingsDepotsUmdsModule SettingsDepotsUmdsModule => new SettingsDepotsUmdsModule(restClient, cancellationToken, timeout, retry);
        public SettingsDepotsUmdsContentModule SettingsDepotsUmdsContentModule => new SettingsDepotsUmdsContentModule(restClient, cancellationToken, timeout, retry);
        public SettingsDepotsModule SettingsDepotsModule => new SettingsDepotsModule(restClient, cancellationToken, timeout, retry);
        public SettingsHardwareSupportManagersModule SettingsHardwareSupportManagersModule => new SettingsHardwareSupportManagersModule(restClient, cancellationToken, timeout, retry);
        public SettingsHardwareSupportManagersPackagesModule SettingsHardwareSupportManagersPackagesModule => new SettingsHardwareSupportManagersPackagesModule(restClient, cancellationToken, timeout, retry);
        public SettingsHardwareSupportManagersPackagesVersionsModule SettingsHardwareSupportManagersPackagesVersionsModule => new SettingsHardwareSupportManagersPackagesVersionsModule(restClient, cancellationToken, timeout, retry);
        public SettingsHostsSoftwareModule SettingsHostsSoftwareModule => new SettingsHostsSoftwareModule(restClient, cancellationToken, timeout, retry);
        public HostsSoftwareModule HostsSoftwareModule => new HostsSoftwareModule(restClient, cancellationToken, timeout, retry);
    }
}