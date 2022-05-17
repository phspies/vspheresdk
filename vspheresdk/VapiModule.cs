using System;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Serializers.NewtonsoftJson;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using vspheresdk.Vapi.Modules;
using vspheresdk;
using System.Threading;

namespace vspheresdk
{
    public class VapiSubModule
    {
        JsonSerializerSettings defaultSerializationSettings;
        RestClient restClient;
        private CancellationToken cancellationToken;
        private int timeout;
        private int retry;
        public VapiSubModule(RestClient RestClient, CancellationToken _cancellationToken = default(CancellationToken), int Port = 443, int _timeout = 5, int _retry = 2)
        {
            cancellationToken = _cancellationToken;
            timeout = _timeout;
            retry = _retry;
            restClient = RestClient;
        }
        public MetadataAuthenticationComponentModule MetadataAuthenticationComponentModule => new MetadataAuthenticationComponentModule(restClient, cancellationToken, timeout, retry);
        public MetadataAuthenticationPackageModule MetadataAuthenticationPackageModule => new MetadataAuthenticationPackageModule(restClient, cancellationToken, timeout, retry);
        public MetadataAuthenticationServiceModule MetadataAuthenticationServiceModule => new MetadataAuthenticationServiceModule(restClient, cancellationToken, timeout, retry);
        public MetadataAuthenticationServiceOperationModule MetadataAuthenticationServiceOperationModule => new MetadataAuthenticationServiceOperationModule(restClient, cancellationToken, timeout, retry);
        public MetadataCliCommandModule MetadataCliCommandModule => new MetadataCliCommandModule(restClient, cancellationToken, timeout, retry);
        public MetadataCliNamespaceModule MetadataCliNamespaceModule => new MetadataCliNamespaceModule(restClient, cancellationToken, timeout, retry);
        public MetadataMetamodelComponentModule MetadataMetamodelComponentModule => new MetadataMetamodelComponentModule(restClient, cancellationToken, timeout, retry);
        public MetadataMetamodelEnumerationModule MetadataMetamodelEnumerationModule => new MetadataMetamodelEnumerationModule(restClient, cancellationToken, timeout, retry);
        public MetadataMetamodelPackageModule MetadataMetamodelPackageModule => new MetadataMetamodelPackageModule(restClient, cancellationToken, timeout, retry);
        public MetadataMetamodelResourceModule MetadataMetamodelResourceModule => new MetadataMetamodelResourceModule(restClient, cancellationToken, timeout, retry);
        public MetadataMetamodelResourceModelModule MetadataMetamodelResourceModelModule => new MetadataMetamodelResourceModelModule(restClient, cancellationToken, timeout, retry);
        public MetadataMetamodelServiceModule MetadataMetamodelServiceModule => new MetadataMetamodelServiceModule(restClient, cancellationToken, timeout, retry);
        public MetadataMetamodelServiceOperationModule MetadataMetamodelServiceOperationModule => new MetadataMetamodelServiceOperationModule(restClient, cancellationToken, timeout, retry);
        public MetadataMetamodelStructureModule MetadataMetamodelStructureModule => new MetadataMetamodelStructureModule(restClient, cancellationToken, timeout, retry);
        public MetadataPrivilegeComponentModule MetadataPrivilegeComponentModule => new MetadataPrivilegeComponentModule(restClient, cancellationToken, timeout, retry);
        public MetadataPrivilegePackageModule MetadataPrivilegePackageModule => new MetadataPrivilegePackageModule(restClient, cancellationToken, timeout, retry);
        public MetadataPrivilegeServiceModule MetadataPrivilegeServiceModule => new MetadataPrivilegeServiceModule(restClient, cancellationToken, timeout, retry);
        public MetadataPrivilegeServiceOperationModule MetadataPrivilegeServiceOperationModule => new MetadataPrivilegeServiceOperationModule(restClient, cancellationToken, timeout, retry);
        public VcenterActivationModule VcenterActivationModule => new VcenterActivationModule(restClient, cancellationToken, timeout, retry);
        public RestNavigationComponentModule RestNavigationComponentModule => new RestNavigationComponentModule(restClient, cancellationToken, timeout, retry);
        public RestNavigationOptionsModule RestNavigationOptionsModule => new RestNavigationOptionsModule(restClient, cancellationToken, timeout, retry);
        public RestNavigationResourceModule RestNavigationResourceModule => new RestNavigationResourceModule(restClient, cancellationToken, timeout, retry);
        public RestNavigationRootModule RestNavigationRootModule => new RestNavigationRootModule(restClient, cancellationToken, timeout, retry);
        public RestNavigationServiceModule RestNavigationServiceModule => new RestNavigationServiceModule(restClient, cancellationToken, timeout, retry);
    }
}