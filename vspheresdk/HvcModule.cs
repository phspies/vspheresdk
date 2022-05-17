using System;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Serializers.NewtonsoftJson;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using vspheresdk.Hvc.Modules;
using vspheresdk;
using System.Threading;

namespace vspheresdk
{
    public class HvcSubModule
    {
        RestClient restClient;
        private CancellationToken cancellationToken;
        private int timeout;
        private int retry;
        public HvcSubModule(RestClient RestClient, CancellationToken _cancellationToken = default(CancellationToken), int _timeout = 5, int _retry = 2)
        {
            cancellationToken = _cancellationToken;
            timeout = _timeout;
            retry = _retry;
            restClient = RestClient;
        }
        public HvcLinksModule HvcLinksModule => new HvcLinksModule(restClient, cancellationToken, timeout, retry);
        public HvcLinksSyncProvidersModule HvcLinksSyncProvidersModule => new HvcLinksSyncProvidersModule(restClient, cancellationToken, timeout, retry);
        public HvcLinksSyncModule HvcLinksSyncModule => new HvcLinksSyncModule(restClient, cancellationToken, timeout, retry);
        public HvcManagementAdministratorsModule HvcManagementAdministratorsModule => new HvcManagementAdministratorsModule(restClient, cancellationToken, timeout, retry);
    }
}