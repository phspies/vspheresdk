using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Newtonsoft.Json;
using System.Net;
using vspheresdk;
using vspheresdk.Vcenter.Models;
using vspheresdk.Vcenter.Models.Enums;

namespace vspheresdk.Vcenter.Modules
{
    public class CryptoManagerHostsKmsProvidersModule
    {
        private RestClient restClient;
        private int retry;
        private int timeout;
        private CancellationToken cancellationToken;

        public CryptoManagerHostsKmsProvidersModule(RestClient Client, CancellationToken _cancellationToken, int _timeout, int _retry)
        {
            restClient = Client;
            retry = _retry;
            timeout = _timeout;
            cancellationToken = _cancellationToken;
        }
        public async Task<List<VcenterCryptoManagerHostsKmsProvidersSummaryType>> ListAsync(string Host, string Providers = null, string Health = null, string Types = null)
        {
            ArgumentNullException.ThrowIfNull(Host, "Host cannot be null");
            StringBuilder ListServiceURL = new StringBuilder("/api/vcenter/crypto-manager/hosts/{host}/kms/providers");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            ListServiceURL.Replace("{host}", System.Uri.EscapeDataString(Helpers.ConvertToString(Host, System.Globalization.CultureInfo.InvariantCulture)));
            if (Providers != null) { request.AddQueryParameter("providers", Providers.ToString()); }
            if (Health != null) { request.AddQueryParameter("health", Health.ToString()); }
            if (Types != null) { request.AddQueryParameter("types", Types.ToString()); }
            request.Resource = ListServiceURL.ToString();
            RestResponse<List<VcenterCryptoManagerHostsKmsProvidersSummaryType>> response = await restClient.ExecuteTaskAsyncWithPolicy<List<VcenterCryptoManagerHostsKmsProvidersSummaryType>>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if there is a generic error.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if the host identifier is empty or the FilterSpec is invalid.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the host is not found.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the caller is not authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the caller is not authorized.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
        public async Task<VcenterCryptoManagerHostsKmsProvidersInfoType> GetAsync(string Host, string Provider)
        {
            ArgumentNullException.ThrowIfNull(Host, "Host cannot be null");
            ArgumentNullException.ThrowIfNull(Provider, "Provider cannot be null");
            StringBuilder GetServiceURL = new StringBuilder("/api/vcenter/crypto-manager/hosts/{host}/kms/providers/{provider}");
            var request = new RestRequest
            {              
                RequestFormat = DataFormat.Json,
                Method = Method.Get
            };
            GetServiceURL.Replace("{host}", System.Uri.EscapeDataString(Helpers.ConvertToString(Host, System.Globalization.CultureInfo.InvariantCulture)));
            GetServiceURL.Replace("{provider}", System.Uri.EscapeDataString(Helpers.ConvertToString(Provider, System.Globalization.CultureInfo.InvariantCulture)));
            request.Resource = GetServiceURL.ToString();
            RestResponse<VcenterCryptoManagerHostsKmsProvidersInfoType> response = await restClient.ExecuteTaskAsyncWithPolicy<VcenterCryptoManagerHostsKmsProvidersInfoType>(request, cancellationToken, timeout, retry);
            if (200 <= (int)response.StatusCode && (int)response.StatusCode <= 300) { return response.Data; }
            else if ((int)response.StatusCode == 500) { throw new vSphereException("if there is a generic error.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 400) { throw new vSphereException("if the host identifier is empty or the provider identifier is empty.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 404) { throw new vSphereException("if the provider or the host is not found.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 401) { throw new vSphereException("if the caller is not authenticated.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else if ((int)response.StatusCode == 403) { throw new vSphereException("if the caller is not authorized.", (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); }
            else { throw new vSphereException(response.ErrorMessage, (int)response.StatusCode, response.Content, response.Headers, response.ErrorException); } 
            return response.Data;
        }
    }
}
