using System;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Serializers.NewtonsoftJson;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using vspheresdk.Library.Modules;
using vspheresdk;
using System.Threading;

namespace vspheresdk
{
    public class LibrarySubModule
    {
        JsonSerializerSettings defaultSerializationSettings;
        RestClient restClient;
        private CancellationToken cancellationToken;
        private int timeout;
        private int retry;
        public LibrarySubModule(RestClient RestClient, CancellationToken _cancellationToken = default(CancellationToken), int Port = 443, int _timeout = 5, int _retry = 2)
        {
            cancellationToken = _cancellationToken;
            timeout = _timeout;
            retry = _retry;
            restClient = RestClient;
        }
        public ConfigurationModule ConfigurationModule => new ConfigurationModule(restClient, cancellationToken, timeout, retry);
        public LibraryModule LibraryModule => new LibraryModule(restClient, cancellationToken, timeout, retry);
        public LibraryItemModule LibraryItemModule => new LibraryItemModule(restClient, cancellationToken, timeout, retry);
        public LibraryItemDownloadSessionModule LibraryItemDownloadSessionModule => new LibraryItemDownloadSessionModule(restClient, cancellationToken, timeout, retry);
        public LibraryItemDownloadsessionFileModule LibraryItemDownloadsessionFileModule => new LibraryItemDownloadsessionFileModule(restClient, cancellationToken, timeout, retry);
        public LibraryItemUpdateSessionModule LibraryItemUpdateSessionModule => new LibraryItemUpdateSessionModule(restClient, cancellationToken, timeout, retry);
        public LibraryItemUpdatesessionFileModule LibraryItemUpdatesessionFileModule => new LibraryItemUpdatesessionFileModule(restClient, cancellationToken, timeout, retry);
        public LibraryItemFileModule LibraryItemFileModule => new LibraryItemFileModule(restClient, cancellationToken, timeout, retry);
        public LibraryItemStorageModule LibraryItemStorageModule => new LibraryItemStorageModule(restClient, cancellationToken, timeout, retry);
        public LibraryItemChangesModule LibraryItemChangesModule => new LibraryItemChangesModule(restClient, cancellationToken, timeout, retry);
        public LibrarySubscribedItemModule LibrarySubscribedItemModule => new LibrarySubscribedItemModule(restClient, cancellationToken, timeout, retry);
        public LibrarySubscriptionsModule LibrarySubscriptionsModule => new LibrarySubscriptionsModule(restClient, cancellationToken, timeout, retry);
        public LocalLibraryModule LocalLibraryModule => new LocalLibraryModule(restClient, cancellationToken, timeout, retry);
        public SecurityPoliciesModule SecurityPoliciesModule => new SecurityPoliciesModule(restClient, cancellationToken, timeout, retry);
        public SubscribedLibraryModule SubscribedLibraryModule => new SubscribedLibraryModule(restClient, cancellationToken, timeout, retry);
        public TrustedCertificatesModule TrustedCertificatesModule => new TrustedCertificatesModule(restClient, cancellationToken, timeout, retry);
        public TypeModule TypeModule => new TypeModule(restClient, cancellationToken, timeout, retry);
    }
}