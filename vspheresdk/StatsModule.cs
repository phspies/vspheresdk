using System;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Serializers.NewtonsoftJson;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using vspheresdk.Stats.Modules;
using vspheresdk;
using System.Threading;

namespace vspheresdk
{
    public class StatsSubModule
    {
        JsonSerializerSettings defaultSerializationSettings;
        RestClient restClient;
        private CancellationToken cancellationToken;
        private int timeout;
        private int retry;
        public StatsSubModule(RestClient RestClient, CancellationToken _cancellationToken = default(CancellationToken), int Port = 443, int _timeout = 5, int _retry = 2)
        {
            cancellationToken = _cancellationToken;
            timeout = _timeout;
            retry = _retry;
            restClient = RestClient;
        }
        public AcqSpecsModule AcqSpecsModule => new AcqSpecsModule(restClient, cancellationToken, timeout, retry);
        public CounterSetsModule CounterSetsModule => new CounterSetsModule(restClient, cancellationToken, timeout, retry);
        public CountersModule CountersModule => new CountersModule(restClient, cancellationToken, timeout, retry);
        public CounterMetadataModule CounterMetadataModule => new CounterMetadataModule(restClient, cancellationToken, timeout, retry);
        public DataModule DataModule => new DataModule(restClient, cancellationToken, timeout, retry);
        public MetricsModule MetricsModule => new MetricsModule(restClient, cancellationToken, timeout, retry);
        public ProvidersModule ProvidersModule => new ProvidersModule(restClient, cancellationToken, timeout, retry);
        public ResourceAddressSchemasModule ResourceAddressSchemasModule => new ResourceAddressSchemasModule(restClient, cancellationToken, timeout, retry);
        public ResourceAddressesModule ResourceAddressesModule => new ResourceAddressesModule(restClient, cancellationToken, timeout, retry);
        public ResourceTypesModule ResourceTypesModule => new ResourceTypesModule(restClient, cancellationToken, timeout, retry);
    }
}