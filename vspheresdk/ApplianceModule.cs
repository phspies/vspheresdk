using System;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Serializers.NewtonsoftJson;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using vspheresdk.Appliance.Modules;
using vspheresdk;
using System.Threading;

namespace vspheresdk
{
    public class ApplianceSubModule
    {
        RestClient restClient;
        private CancellationToken cancellationToken;
        private int timeout;
        private int retry;
        public ApplianceSubModule(RestClient RestClient, CancellationToken _cancellationToken = default(CancellationToken), int _timeout = 5, int _retry = 2)
        {
            cancellationToken = _cancellationToken;
            timeout = _timeout;
            retry = _retry;
            restClient = RestClient;
        }
        public AccessConsolecliModule AccessConsolecliModule => new AccessConsolecliModule(restClient, cancellationToken, timeout, retry);
        public AccessDcuiModule AccessDcuiModule => new AccessDcuiModule(restClient, cancellationToken, timeout, retry);
        public AccessShellModule AccessShellModule => new AccessShellModule(restClient, cancellationToken, timeout, retry);
        public AccessSshModule AccessSshModule => new AccessSshModule(restClient, cancellationToken, timeout, retry);
        public HealthApplmgmtModule HealthApplmgmtModule => new HealthApplmgmtModule(restClient, cancellationToken, timeout, retry);
        public HealthDatabaseModule HealthDatabaseModule => new HealthDatabaseModule(restClient, cancellationToken, timeout, retry);
        public HealthDatabasestorageModule HealthDatabasestorageModule => new HealthDatabasestorageModule(restClient, cancellationToken, timeout, retry);
        public HealthLoadModule HealthLoadModule => new HealthLoadModule(restClient, cancellationToken, timeout, retry);
        public HealthMemModule HealthMemModule => new HealthMemModule(restClient, cancellationToken, timeout, retry);
        public HealthCheckSettingsModule HealthCheckSettingsModule => new HealthCheckSettingsModule(restClient, cancellationToken, timeout, retry);
        public HealthSoftwarepackagesModule HealthSoftwarepackagesModule => new HealthSoftwarepackagesModule(restClient, cancellationToken, timeout, retry);
        public HealthStorageModule HealthStorageModule => new HealthStorageModule(restClient, cancellationToken, timeout, retry);
        public HealthSwapModule HealthSwapModule => new HealthSwapModule(restClient, cancellationToken, timeout, retry);
        public HealthSystemModule HealthSystemModule => new HealthSystemModule(restClient, cancellationToken, timeout, retry);
        public HealthModule HealthModule => new HealthModule(restClient, cancellationToken, timeout, retry);
        public InfraprofileConfigsModule InfraprofileConfigsModule => new InfraprofileConfigsModule(restClient, cancellationToken, timeout, retry);
        public LocalAccountsModule LocalAccountsModule => new LocalAccountsModule(restClient, cancellationToken, timeout, retry);
        public LocalAccountsPolicyModule LocalAccountsPolicyModule => new LocalAccountsPolicyModule(restClient, cancellationToken, timeout, retry);
        public LoggingForwardingModule LoggingForwardingModule => new LoggingForwardingModule(restClient, cancellationToken, timeout, retry);
        public MonitoringModule MonitoringModule => new MonitoringModule(restClient, cancellationToken, timeout, retry);
        public NetworkingModule NetworkingModule => new NetworkingModule(restClient, cancellationToken, timeout, retry);
        public NetworkingDnsDomainsModule NetworkingDnsDomainsModule => new NetworkingDnsDomainsModule(restClient, cancellationToken, timeout, retry);
        public NetworkingDnsHostnameModule NetworkingDnsHostnameModule => new NetworkingDnsHostnameModule(restClient, cancellationToken, timeout, retry);
        public NetworkingDnsServersModule NetworkingDnsServersModule => new NetworkingDnsServersModule(restClient, cancellationToken, timeout, retry);
        public NetworkingFirewallInboundModule NetworkingFirewallInboundModule => new NetworkingFirewallInboundModule(restClient, cancellationToken, timeout, retry);
        public NetworkingInterfacesModule NetworkingInterfacesModule => new NetworkingInterfacesModule(restClient, cancellationToken, timeout, retry);
        public NetworkingInterfacesIpv4Module NetworkingInterfacesIpv4Module => new NetworkingInterfacesIpv4Module(restClient, cancellationToken, timeout, retry);
        public NetworkingInterfacesIpv6Module NetworkingInterfacesIpv6Module => new NetworkingInterfacesIpv6Module(restClient, cancellationToken, timeout, retry);
        public NetworkingNoProxyModule NetworkingNoProxyModule => new NetworkingNoProxyModule(restClient, cancellationToken, timeout, retry);
        public NetworkingProxyModule NetworkingProxyModule => new NetworkingProxyModule(restClient, cancellationToken, timeout, retry);
        public NtpModule NtpModule => new NtpModule(restClient, cancellationToken, timeout, retry);
        public RecoveryModule RecoveryModule => new RecoveryModule(restClient, cancellationToken, timeout, retry);
        public RecoveryBackupJobModule RecoveryBackupJobModule => new RecoveryBackupJobModule(restClient, cancellationToken, timeout, retry);
        public RecoveryBackupJobDetailsModule RecoveryBackupJobDetailsModule => new RecoveryBackupJobDetailsModule(restClient, cancellationToken, timeout, retry);
        public RecoveryBackupPartsModule RecoveryBackupPartsModule => new RecoveryBackupPartsModule(restClient, cancellationToken, timeout, retry);
        public RecoveryBackupSchedulesModule RecoveryBackupSchedulesModule => new RecoveryBackupSchedulesModule(restClient, cancellationToken, timeout, retry);
        public RecoveryBackupSystemNameArchiveModule RecoveryBackupSystemNameArchiveModule => new RecoveryBackupSystemNameArchiveModule(restClient, cancellationToken, timeout, retry);
        public RecoveryBackupSystemNameModule RecoveryBackupSystemNameModule => new RecoveryBackupSystemNameModule(restClient, cancellationToken, timeout, retry);
        public RecoveryBackupModule RecoveryBackupModule => new RecoveryBackupModule(restClient, cancellationToken, timeout, retry);
        public RecoveryReconciliationJobModule RecoveryReconciliationJobModule => new RecoveryReconciliationJobModule(restClient, cancellationToken, timeout, retry);
        public RecoveryRestoreJobModule RecoveryRestoreJobModule => new RecoveryRestoreJobModule(restClient, cancellationToken, timeout, retry);
        public RecoveryRestoreModule RecoveryRestoreModule => new RecoveryRestoreModule(restClient, cancellationToken, timeout, retry);
        public ServicesModule ServicesModule => new ServicesModule(restClient, cancellationToken, timeout, retry);
        public ShutdownModule ShutdownModule => new ShutdownModule(restClient, cancellationToken, timeout, retry);
        public SupportBundleModule SupportBundleModule => new SupportBundleModule(restClient, cancellationToken, timeout, retry);
        public SupportBundleComponentsModule SupportBundleComponentsModule => new SupportBundleComponentsModule(restClient, cancellationToken, timeout, retry);
        public SystemSecurityGlobalFipsModule SystemSecurityGlobalFipsModule => new SystemSecurityGlobalFipsModule(restClient, cancellationToken, timeout, retry);
        public SystemStorageModule SystemStorageModule => new SystemStorageModule(restClient, cancellationToken, timeout, retry);
        public SystemTimeModule SystemTimeModule => new SystemTimeModule(restClient, cancellationToken, timeout, retry);
        public SystemTimeTimezoneModule SystemTimeTimezoneModule => new SystemTimeTimezoneModule(restClient, cancellationToken, timeout, retry);
        public SystemUptimeModule SystemUptimeModule => new SystemUptimeModule(restClient, cancellationToken, timeout, retry);
        public SystemVersionModule SystemVersionModule => new SystemVersionModule(restClient, cancellationToken, timeout, retry);
        public TimesyncModule TimesyncModule => new TimesyncModule(restClient, cancellationToken, timeout, retry);
        public UpdateModule UpdateModule => new UpdateModule(restClient, cancellationToken, timeout, retry);
        public UpdatePendingModule UpdatePendingModule => new UpdatePendingModule(restClient, cancellationToken, timeout, retry);
        public UpdatePolicyModule UpdatePolicyModule => new UpdatePolicyModule(restClient, cancellationToken, timeout, retry);
        public UpdateStagedModule UpdateStagedModule => new UpdateStagedModule(restClient, cancellationToken, timeout, retry);
        public VcenterSettingsV1ConfigModule VcenterSettingsV1ConfigModule => new VcenterSettingsV1ConfigModule(restClient, cancellationToken, timeout, retry);
        public VcenterSettingsV1ConfigCurrentModule VcenterSettingsV1ConfigCurrentModule => new VcenterSettingsV1ConfigCurrentModule(restClient, cancellationToken, timeout, retry);
        public VmonServiceModule VmonServiceModule => new VmonServiceModule(restClient, cancellationToken, timeout, retry);
    }
}