using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Serializers.NewtonsoftJson;
using System;
using System.Linq;
using vspheresdk.Authentication;

namespace vspheresdk
{
    public class vSphereClient
    {
        private RestClient tokenRestClient { get; set; }
        private RestClient sessionRestClient { get; set; }
        private CancellationToken cancellationToken;
        public int Timeout;
        public int Retry;
        public LoginResponseType LoginResponseDetails;

        public vSphereClient(string Host, string Username, string Password, bool? RemoteCertificateValidation = true, JsonSerializerSettings? DefaultSerializationSettings = null, CancellationToken _cancellationToken = default(CancellationToken), int Port = 443, int _timeout = 100, int _retry = 2, string _defaultXAviVerion = null)
        {
            cancellationToken = _cancellationToken;
            Timeout = _timeout;
            Retry = _retry;

            var tokenUri = new UriBuilder(Host)
            {
                Scheme = Uri.UriSchemeHttps,
                Port = Port,
            }.Uri;
            var sessionUri = new UriBuilder(Host)
            {
                Scheme = Uri.UriSchemeHttps,
                Port = Port,
                Path = ""
            }.Uri;
            var tokenRestOptions = new RestClientOptions() { BaseUrl = tokenUri };
            var sessionRestOptions = new RestClientOptions() { BaseUrl = sessionUri };
            if (!RemoteCertificateValidation ?? false)
            {
                tokenRestOptions.RemoteCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;
                sessionRestOptions.RemoteCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;
            };
            tokenRestClient = new RestClient(tokenRestOptions);
            sessionRestClient = new RestClient(sessionRestOptions);
            sessionRestClient.AcceptedContentTypes = new string[] { "application/json" };
            sessionRestClient.AcceptedContentTypes = new string[] { "application/json" };
            sessionRestClient.Authenticator = new HttpBasicAuthenticator(Username, Password);

            if (DefaultSerializationSettings == null)
            {
                DefaultSerializationSettings = new JsonSerializerSettings
                {
                    Error = (se, ev) => { ev.ErrorContext.Handled = true; },
                    DefaultValueHandling = DefaultValueHandling.Include,
                    TypeNameHandling = TypeNameHandling.Auto,
                    NullValueHandling = NullValueHandling.Ignore,
                    Formatting = Formatting.None,
                    ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
                    Converters = new List<JsonConverter>() { new Newtonsoft.Json.Converters.StringEnumConverter() }
                };
            };
            tokenRestClient.UseNewtonsoftJson(DefaultSerializationSettings);
            sessionRestClient.UseNewtonsoftJson(DefaultSerializationSettings);
        }
        public async Task<LoginResponseType> LoginAsync()
        {
            RestResponse<LoginResponseType> response = await AuthenticationHelper.LoginAsync(sessionRestClient, cancellationToken, Timeout, Retry);
            ArgumentNullException.ThrowIfNull(response.Data.Value);
     
            tokenRestClient.AddDefaultHeader("vmware-api-session-id", response.Data.Value);
            sessionRestClient.AddDefaultHeader("vmware-api-session-id", response.Data.Value);
            return response.Data;
        }
        public async Task LogoutAsync()
        {
            await AuthenticationHelper.LogoutAsync(sessionRestClient, cancellationToken, Timeout, Retry);
        }
        public async Task<string> RetrieveAsync()
        {
            return await AuthenticationHelper.RetrieveAsync(sessionRestClient, cancellationToken, Timeout, Retry);
        }
        public ApplianceSubModule ApplianceSubModule => new ApplianceSubModule(tokenRestClient, cancellationToken, Timeout, Retry);
        public CisSubModule CisSubModule => new CisSubModule(tokenRestClient, cancellationToken, Timeout, Retry);
        public EsxSubModule EsxSubModule => new EsxSubModule(tokenRestClient, cancellationToken, Timeout, Retry);
        public HvcSubModule HvcSubModule => new HvcSubModule(tokenRestClient, cancellationToken, Timeout, Retry);
        public LibrarySubModule LibrarySubModule => new LibrarySubModule(tokenRestClient, cancellationToken, Timeout, Retry);
        public StatsSubModule StatsSubModule => new StatsSubModule(tokenRestClient, cancellationToken, Timeout, Retry);
        public VapiSubModule VapiSubModule => new VapiSubModule(tokenRestClient, cancellationToken, Timeout, Retry);
        public VcenterSubModule VcenterSubModule => new VcenterSubModule(tokenRestClient, cancellationToken, Timeout, Retry);

    }
}