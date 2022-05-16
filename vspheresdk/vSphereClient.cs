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
        private int timeout;
        private int retry;
        public LoginResponseType LoginResponseDetails;

        public vSphereClient(string Host, string Username, string Password, bool? RemoteCertificateValidation = true, JsonSerializerSettings? DefaultSerializationSettings = null, CancellationToken _cancellationToken = default(CancellationToken), int Port = 443, int _timeout = 100, int _retry = 2, string _defaultXAviVerion = null)
        {
            cancellationToken = _cancellationToken;
            timeout = _timeout;
            retry = _retry;


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
            RestResponse<LoginResponseType> response = await AuthenticationHelper.LoginAsync(sessionRestClient, cancellationToken, timeout, retry);
            ArgumentNullException.ThrowIfNull(response.Data.Value);
     
            tokenRestClient.AddDefaultHeader("vmware-api-session-id", response.Data.Value);
            sessionRestClient.AddDefaultHeader("vmware-api-session-id", response.Data.Value);
            return response.Data;
        }
        public async Task LogoutAsync()
        {
            await AuthenticationHelper.LogoutAsync(sessionRestClient, cancellationToken, timeout, retry);
        }
        public LibrarySubModule LibrarySubModule => new LibrarySubModule(tokenRestClient, cancellationToken, timeout, retry);
        public StatsSubModule StatsSubModule => new StatsSubModule(tokenRestClient, cancellationToken, timeout, retry);
        public VcenterSubModule VcenterSubModule => new VcenterSubModule(tokenRestClient, cancellationToken, timeout, retry);

    }
}