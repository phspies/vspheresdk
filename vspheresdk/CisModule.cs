using System;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Serializers.NewtonsoftJson;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using vspheresdk.Cis.Modules;
using vspheresdk;
using System.Threading;

namespace vspheresdk
{
    public class CisSubModule
    {
        JsonSerializerSettings defaultSerializationSettings;
        RestClient restClient;
        private CancellationToken cancellationToken;
        private int timeout;
        private int retry;
        public CisSubModule(RestClient RestClient, CancellationToken _cancellationToken = default(CancellationToken), int Port = 443, int _timeout = 5, int _retry = 2)
        {
            cancellationToken = _cancellationToken;
            timeout = _timeout;
            retry = _retry;
            restClient = RestClient;
        }
        public TaggingCategoryModule TaggingCategoryModule => new TaggingCategoryModule(restClient, cancellationToken, timeout, retry);
        public TaggingTagModule TaggingTagModule => new TaggingTagModule(restClient, cancellationToken, timeout, retry);
        public TaggingTagAssociationModule TaggingTagAssociationModule => new TaggingTagAssociationModule(restClient, cancellationToken, timeout, retry);
        public TasksModule TasksModule => new TasksModule(restClient, cancellationToken, timeout, retry);
        public SessionModule SessionModule => new SessionModule(restClient, cancellationToken, timeout, retry);
    }
}